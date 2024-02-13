using System.Collections.Generic;
using System.Linq;

namespace DataStructures.SimplifiedDataStructures
{
    public class TerjesDictionary
    {
        private readonly List<string>[] _values;
        private readonly List<string>[] _keys;

        public TerjesDictionary()
        {
            _values = new List<string>[1000];
            _keys = new List<string>[1000];
            for (var i = 0; i < 1000; i++)
            {
                _values[i] = new List<string>();
                _keys[i] = new List<string>();
            }
        }

        public string GetValue(string key)
        {
            var hashCode = GetHashCode(key);
            var keyList = _keys[hashCode];
            var index = keyList.FindIndex(s => s == key);
            if (index == -1) return null;
            return _values[hashCode][index];
        }

        private int GetHashCode(string key)
        {
            return key.GetHashCode() % 1000;
        }

        public void Edit(string key, string value)
        {
            var index = Array.IndexOf(_keys, key);
            if (index >= 0)
            {
                var list = _values[index];
                list.Add(value);
            }
            else
            {
                var list = new List<string>();
                _keys.Add(key);
                _values.Add(value);
            }
        }

        public bool ContainsKey(string key)
        {
            return _keys.Contains(key);
        }

        public IEnumerable<string> GetKeys()
        {
            return _keys;
        }
    }
}
