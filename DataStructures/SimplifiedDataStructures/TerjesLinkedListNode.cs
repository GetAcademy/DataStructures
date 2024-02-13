namespace DataStructures.SimplifiedDataStructures
{
    class TerjesLinkedListNode
    {
        public string Value { get; }
        public TerjesLinkedListNode Next { get; set; }

        public TerjesLinkedListNode(string value)
        {
            this.Value = value;
        }
    }
}
