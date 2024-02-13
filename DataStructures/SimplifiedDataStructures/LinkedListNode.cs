namespace DataStructures.SimplifiedDataStructures
{
    class LinkedListNode
    {
        public string Value { get; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(string value)
        {
            this.Value = value;
        }
    }
}
