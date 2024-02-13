namespace DataStructures.SimplifiedDataStructures
{
    internal class TerjesBinaryTreeNode
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public TerjesBinaryTreeNode Left { get; set; }
        public TerjesBinaryTreeNode Right { get; set; }

        public TerjesBinaryTreeNode(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
