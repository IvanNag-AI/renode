"""Restore exact Renode source snapshots using ONLY the owner's archive URLs.
Python 3 + Git, no upstream installers or build scripts are executed.
"""
import argparse,json,pathlib,subprocess,datetime
P=argparse.ArgumentParser();P.add_argument('destination');P.add_argument('--snapshot',default='v1.17.0');args=P.parse_args()
base=pathlib.Path(__file__).resolve().parent
m=json.loads((base/'manifest.json').read_text(encoding='utf-8'))
dest=pathlib.Path(args.destination).resolve()
if dest.exists():raise SystemExit('Destination must not exist: '+str(dest))
root=m['snapshots'][args.snapshot]
events=[]
def cmd(*argv):
 p=subprocess.run([str(a) for a in argv],capture_output=True,text=True,encoding='utf-8',errors='replace')
 if p.returncode:raise RuntimeError(str(argv)+': '+p.stderr[-3000:])
 return p.stdout.strip()
def restore(repo,sha,path):
 e=m['repositories'][repo];url=e['archive_git'];ref=e['pin_refs'][sha]
 if not url.startswith('https://github.com/'+m['owner']+'/'):raise RuntimeError('Not owner archive URL: '+url)
 path.mkdir(parents=True,exist_ok=True)
 cmd('git','-c','core.longpaths=true','init',path)
 cmd('git','-C',path,'config','core.longpaths','true')
 cmd('git','-C',path,'remote','add','origin',url)
 cmd('git','-C',path,'fetch','--no-tags','origin',ref)
 cmd('git','-C',path,'checkout','--detach',sha)
 if cmd('git','-C',path,'rev-parse','HEAD')!=sha:raise RuntimeError('SHA mismatch')
 cmd('git','-C',path,'fsck','--full','--no-dangling')
 events.append({'repo':repo,'sha':sha,'url':url,'fsck':'passed','path':str(path.relative_to(dest))})
 for edge in m['edges']:
  if edge['parent']==repo and edge['parent_sha']==sha:
   if not edge.get('repository'):raise RuntimeError('Unarchived submodule: '+str(edge))
   child=m['repositories'][edge['repository']]
   cmd('git','-C',path,'config','submodule.'+edge['path']+'.url',child['archive_git'])
   # Git may create empty gitlink directories at checkout; cloning into empty is supported.
   restore(edge['repository'],edge['sha'],path/edge['path'])
restore('renode/renode',root,dest)
report={'utc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'snapshot':args.snapshot,'root_sha':root,'sources':'owner GitHub URLs only; no local alternates','repositories':events,'result':'passed','build_executed':False}
out=dest.parent/(dest.name+'-verification.json');out.write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
print('RESTORED',len(events),'repositories;',out)
