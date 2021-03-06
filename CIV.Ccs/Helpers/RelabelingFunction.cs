﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CIV.Ccs
{
    public class RelabelingFunction : ICollection<KeyValuePair<string, string>>, IEquatable<RelabelingFunction>
    {
        readonly IDictionary<string, string> dict = new SortedDictionary<string, string>();

        public int Count => dict.Count;

        public bool IsReadOnly => dict.IsReadOnly;

        /// <summary>
        /// Allows square-bracket indexing, i.e. relabeling[key].
        /// </summary>
        /// <param name="key">The key to access or set.</param>
        public string this[string key] => dict[key];

        internal bool ContainsKey(string label) => dict.ContainsKey(label);

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
            => dict.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => dict.GetEnumerator();

        public void Add(string action, string relabeled)
        {
            if (action == Const.tau)
            {
                throw new ArgumentException("Cannot relabel tau");
            }
            if (action.IsOutput())
            {
                action = action.Coaction();
                relabeled = relabeled.Coaction();
            }
            dict.Add(action, relabeled);
        }

        public void Add(KeyValuePair<string, string> item) => Add(item.Key, item.Value);

        public void Clear() => dict.Clear();

        public bool Contains(KeyValuePair<string, string> item) => dict.Contains(item);

        public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
            => dict.CopyTo(array, arrayIndex);

        public bool Remove(KeyValuePair<string, string> item) => dict.Remove(item);

        public bool Equals(RelabelingFunction other)
        {
			// https://stackoverflow.com/questions/3804367/
			// We can use this solution because dict is a value-type dictionary,
            // i.e. <string, string>
            return dict.Count == other.dict.Count
                       && !dict.Except(other.dict).Any();
		}

        public override string ToString()
        {
            var relabels = dict
                .Select(x => $"{x.Value}{Const.relab}{x.Key}")
                .ToList();
            return String.Join(",", relabels);
        }
    }
}
