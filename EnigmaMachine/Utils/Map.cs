using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Utils
{
    /// <summary>
    /// bi-directional dictionary mapping utility class
    /// </summary>
    internal class Map<T1, T2>
    {
        private Dictionary<T1, T2> _forward = new Dictionary<T1, T2>();
        private Dictionary<T2, T1> _reverse = new Dictionary<T2, T1>();

        public Map()
        {
            this.Forward = new Indexer<T1, T2>(_forward);
            this.Reverse = new Indexer<T2, T1>(_reverse);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="IndT1"></typeparam>
        /// <typeparam name="IndT2"></typeparam>
        public class Indexer<IndT1, IndT2>
        {
            private Dictionary<IndT1, IndT2> _dict;
            public Indexer(Dictionary<IndT1, IndT2> dict)
            {
                _dict = dict;
            }

            public IndT2 this[IndT1 key]
            {
                get { return _dict[key]; }
                set { _dict[key] = value; }
            }
        }

        /// <summary>
        /// adds a bi-directional mapping between key1 and key2
        /// </summary>
        /// <param name="key1">the first element</param>
        /// <param name="key2">the second element</param>
        public void Add(T1 key1, T2 key2)
        {
            // see if either key already exists
            if (_forward.ContainsKey(key1) || _reverse.ContainsKey(key2))
            {
                throw new ArgumentException("one of the keys already exists in the map.");
            }

            _forward.Add(key1, key2);
            _reverse.Add(key2, key1);
        }

        public Indexer<T1, T2> Forward { get; private set; }
        public Indexer<T2, T1> Reverse { get; private set; }
    }
}
