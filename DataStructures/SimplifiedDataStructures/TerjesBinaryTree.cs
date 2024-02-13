namespace DataStructures.SimplifiedDataStructures
{
    internal class TerjesBinaryTree
    {
        private TerjesBinaryTreeNode? root;

        public void Add(string key, int value)
        {
            root = Add(root, key, value);
        }

        public TerjesBinaryTreeNode Add(TerjesBinaryTreeNode root, string key, int value)
        {
            if (root == null)
            {
                root = new TerjesBinaryTreeNode(key, value);
                return root;
            }

            int comparison = string.CompareOrdinal(key, root.Key);

            if (comparison < 0)
                root.Left = Add(root.Left, key, value);
            else if (comparison > 0)
                root.Right = Add(root.Right, key, value);
            else
                throw new ApplicationException("Duplicate keys not allowed");

            return root;
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
