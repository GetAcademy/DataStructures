namespace DataStructures.SimplifiedDataStructures
{
    class LinkedList
    {
        private LinkedListNode? _first;
        private LinkedListNode? _last;

        public void Add(string value)
        {
            var node = new LinkedListNode(value);
            if (_first == null)
            {
                _first = node;
                _last = node;
            }
            else
            {
                _last.Next = node;
            }
        }

        public void AddFirst(string value)
        {
            var node = new LinkedListNode(value);
            if (_first == null)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Next = _first;
                _first = node;
            }
        }
    }
}
