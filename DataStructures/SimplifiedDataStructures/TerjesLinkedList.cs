namespace DataStructures.SimplifiedDataStructures
{
    class TerjesLinkedList
    {
        private TerjesLinkedListNode? _head;
        private TerjesLinkedListNode? _tail;

        public void Add(string value)
        {
            var node = new TerjesLinkedListNode(value);
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
            }
        }

        //public void AddFirst(string value)
        //{
        //    var node = new TerjesLinkedListNode(value);
        //    if (_head == null)
        //    {
        //        _head = node;
        //        _tail = node;
        //    }
        //    else
        //    {
        //        node.Next = _head;
        //        _head = node;
        //    }
        //}
    }
}
