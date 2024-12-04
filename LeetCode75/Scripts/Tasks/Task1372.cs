namespace LeetCode75.Scripts;

public class Task1372
{
    private int _longestPath = 0;
    public Task1372()
    {
        var tree = TreeNode.ArrayToTree([1, null, 1, 1, 1, null, null, 1, 1, null, 1, null, null, null, 1]);
        var tree2 = TreeNode.ArrayToTree([1,2,2,null,3,null,null,4,4,null,5]);
        var tree3 = TreeNode.ArrayToTree([1,null,2,3,3,null,null,null,4]);
        Console.WriteLine(LongestZigZag(tree3));
    }

    public int LongestZigZag(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        Search(root.left, 1, true);
        Search(root.right, 1);
        return _longestPath;
    }

    private void Search(TreeNode root, int level, bool leftNode = false)
    {
        if (root == null)
        {
            return;
        }

        if (level > _longestPath)
        {
            _longestPath = level;
        }

        Search(root.left, leftNode ? 1 : level + 1, true);
        Search(root.right, !leftNode ? 1 : level + 1);
    }
}