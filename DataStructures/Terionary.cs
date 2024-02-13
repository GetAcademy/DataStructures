using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class Terionary
    {
        private List<string>[] _values;
        private List<string>[] _keys;

        public Terionary()
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
            var sum = key.ToCharArray().Select(c=>(int)c).Sum();
            var hashCode = sum % 1000;
            return hashCode;
        }

        public void Edit(string key, string value)
        {
            var index = _keys.FindIndex(s => s == key);
            if (index >= 0)
            {
                _values[index] = value;
            }
            else
            {
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
