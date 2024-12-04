namespace LeetCode75.Scripts
{
    public class Task872
    {
        public Task872()
        {
            int?[] tree1 = [3, 5, 1, 6, 2, 9, 8, null, null, 7, 4];
            int?[] tree2 = [3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8];
            TreeNode root2 = TreeNode.ArrayToTree(tree2);
            TreeNode root1 = TreeNode.ArrayToTree(tree1);
            var result = LeafSimilar(root1, root2) ? "true" : "false";
            Console.WriteLine(result);
        }

        private bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var stack1 = new Stack<TreeNode>();
            var stack2 = new Stack<TreeNode>();

            stack1.Push(root1);
            stack2.Push(root2);

            var firstTreeLeafs = SearchThree(stack1);
            var secondTreeLeafs = SearchThree(stack2);
            return firstTreeLeafs.SequenceEqual(secondTreeLeafs);
        }

        private static List<int> SearchThree(Stack<TreeNode> stack1)
        {
            var result = new List<int>();
            while (stack1.Count > 0) {
                TreeNode node = stack1.Pop();

                // Сначала добавляем правый узел, чтобы левый узел был наверху стека и обрабатывался первым
                if (node.right != null)
                {
                    stack1.Push(node.right);
                }

                if (node.left != null)
                {
                    stack1.Push(node.left);
                }

                if (node.left == null && node.right == null)
                {
                    result.Add(node.val);
                }
            }

            return result;
        }
    }
}
