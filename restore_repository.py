"""Restore one archived repository's original heads/tags and pinned commits."""
import argparse,pathlib,json,subprocess
p=argparse.ArgumentParser();p.add_argument('upstream',help='owner/repository');p.add_argument('destination');args=p.parse_args()
m=json.loads((pathlib.Path(__file__).parent/'manifest.json').read_text(encoding='utf-8'));e=m['repositories'][args.upstream]
dest=pathlib.Path(args.destination).resolve()
if dest.exists():raise SystemExit('Destination must not exist')
if not e['archive_git'].startswith('https://github.com/'+m['owner']+'/'):raise SystemExit('Not owner archive')
def run(*cmd):
 r=subprocess.run([str(c) for c in cmd],capture_output=True,text=True,encoding='utf-8',errors='replace')
 if r.returncode:raise RuntimeError(r.stderr[-3000:])
 return r.stdout.strip()
run('git','init',dest);run('git','-C',dest,'config','core.longpaths','true');run('git','-C',dest,'config','core.autocrlf','false')
run('git','-C',dest,'remote','add','origin',e['archive_git'])
specs=[r['archive_ref']+':'+r['original_ref'] for r in e['ref_mapping']]
specs += [ref+':refs/archive-pins/'+sha for sha,ref in e['pin_refs'].items()]
for i in range(0,len(specs),40):run('git','-C',dest,'fetch','--no-tags','origin',*specs[i:i+40])
for r in e['ref_mapping']:
 if run('git','-C',dest,'rev-parse',r['original_ref'])!=r['sha']:raise RuntimeError('Ref SHA mismatch: '+r['original_ref'])
run('git','-C',dest,'checkout','--detach',e['sha']);run('git','-C',dest,'fsck','--full','--no-dangling')
print('Restored',args.upstream,len(e['ref_mapping']),'original refs; fsck passed')
