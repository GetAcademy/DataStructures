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
            var hashCode = key.GetHashCode() % 1000;
            var keyList = _keys[hashCode];
            var indexInList = keyList.IndexOf(key);
            if (indexInList == -1) return null;
            return _values[hashCode][indexInList];
        }

        public void SetValue(string key, string value)
        {
            var hashCode = key.GetHashCode() % 1000;
            var keyList = _keys[hashCode];
            var valueList = _values[hashCode];
            var indexInList = keyList.IndexOf(key);
            if (indexInList >= 0)
            {
                valueList[indexInList] = value;
            }
            else
            {
                keyList.Add(key);
                valueList.Add(value);
            }
        }
    }
}
