namespace LeetCode75.Scripts;

public class Task104
{
    public Task104()
    {
        var tree = TreeNode.ArrayToTree([3, 9, 20, null, null, 15, 7]);
        var tree2 = TreeNode.ArrayToTree([1,null,2]);
        Console.WriteLine(MaxDepth(tree2));
    }

    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var treeQueue = new Queue<(TreeNode, int)>();
        treeQueue.Enqueue((root, 1));
        var maxDepth = 1;

        while (treeQueue.Count > 0)
        {
            var (rootNode, level) = treeQueue.Dequeue();
            maxDepth = level;

            if (rootNode.left != null)
            {
                treeQueue.Enqueue((rootNode.left, level + 1));
            }
            if (rootNode.right != null)
            {
                treeQueue.Enqueue((rootNode.right, level + 1));
            }
        }

        return maxDepth;
    }
}