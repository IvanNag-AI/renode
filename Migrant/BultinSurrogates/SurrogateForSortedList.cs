//
// Copyright (c) 2012-2026 Antmicro
//
// This file is licensed under the MIT License.
// Full license text is available in the LICENSE file.

using System.Collections.Generic;

namespace Antmicro.Migrant.BultinSurrogates
{
    internal class SurrogateForSortedList<TKey, TVal> : ISurrogateRestorer
    {
        public SurrogateForSortedList(SortedList<TKey, TVal> list)
        {
            keys = new List<TKey>(list.Count);
            values = new List<TVal>(list.Count);
            comparer = list.Comparer;

            foreach(var key in list.Keys)
            {
                keys.Add(key);
                values.Add(list[key]);
            }
        }

        public object Restore()
        {
            var result = new SortedList<TKey, TVal>(comparer);
            for(var i = 0; i < keys.Count; i++)
            {
                result.Add(keys[i], values[i]);
            }

            return result;
        }

        private readonly List<TKey> keys;
        private readonly List<TVal> values;
        private readonly IComparer<TKey> comparer;
    }
}

