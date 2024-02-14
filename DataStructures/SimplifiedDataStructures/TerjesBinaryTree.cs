namespace DataStructures.SimplifiedDataStructures
{
    internal class TerjesBinaryTree
    {
        private TerjesBinaryTreeNode? root;

        public void Add(string key, int value)
        {
            root = Add(root, key, value);
        }

        public TerjesBinaryTreeNode Add(TerjesBinaryTreeNode node, string key, int value)
        {
            if (node == null)
            {
                return new TerjesBinaryTreeNode(key, value);
            }

            int comparison = string.CompareOrdinal(key, node.Key);

            if (comparison < 0)
                node.Left = Add(node.Left, key, value);
            else if (comparison > 0)
                node.Right = Add(node.Right, key, value);
            else
                throw new ApplicationException("Duplicate keys not allowed");

            return node;
        }

        public TerjesBinaryTreeNode Find(string key, TerjesBinaryTreeNode node = null)
        {
            if (root == null || root.Key == key) return root;
            if (node == null) node = root;


            int comparison = string.CompareOrdinal(key, root.Key);

            if (comparison < 0)
                return Find(key, root.Left);
            else
                return Find(key, root.Right);
        }
    }
}
