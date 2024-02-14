namespace DataStructures.SimplifiedDataStructures
{
    public class TerjesSimpleHashMap
    {
        private readonly List<string>[] _values;

        public TerjesSimpleHashMap()
        {
            _values = new List<string>[1000];
            for (var i = 0; i < 1000; i++)
            {
                _values[i] = new List<string>();
            }
        }

        public bool Contains(string value)
        {
            var hashCode = Math.Abs(value.GetHashCode() % 1000);
            var list = _values[hashCode];
            return list.Contains(value);
        }

        public void Add(string value)
        {
            var hashCode = Math.Abs(value.GetHashCode() % 1000);
            var list = _values[hashCode];
            if (!list.Contains(value))
            {
                list.Add(value);
            }
        }
    }
}
