namespace LeetCode75.Scripts.Tasks;

public class Task94
{
    public Task94()
    {
        var root = TreeNode.ArrayToTree([1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9]);
        var result = InorderTraversal(root).ToList();
        result.ForEach(Console.WriteLine);
    }

    public IList<int> InorderTraversal(TreeNode root)
    {
        var nodes = new List<int>();
        var treeStack = new Stack<TreeNode>();
        var node = root;

        while (treeStack.Count > 0 || node != null)
        {
            while (node != null)
            {
                treeStack.Push(node);
                node = node.left;
            }

            node = treeStack.Pop();
            nodes.Add(node.val);
            node = node.right;
        }

        return nodes;
    }
}