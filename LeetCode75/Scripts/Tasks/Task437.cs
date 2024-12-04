namespace LeetCode75.Scripts;

public class Task437
{
    private int _goodPathAmount = 0;
    public Task437()
    {
        var tree = TreeNode.ArrayToTree([10, 5, -3, 3, 2, null, 11, 3, -2, null, 1]);
        var tree2 = TreeNode.ArrayToTree([1000000000,1000000000,null,294967296,null,1000000000,null,1000000000,null,1000000000]);
        var targetSum = 8;
        var targetSum2 = 0;
        Console.WriteLine(PathSum(tree2, targetSum2));
    }

    public int PathSum(TreeNode root, int targetSum)
    {
        var goodPathsAmount = 0;

        if (root == null)
        {
            return 0;
        }

        PreOrder(root, targetSum, 0, true);
        return _goodPathAmount;
    }

    private void PreOrder(TreeNode root, int targetSum, long sum, bool isRoot = false)
    {
        if (root == null)
        {
            return;
        }

        sum = sum + root.val;

        if (sum == targetSum)
        {
            _goodPathAmount++;
        }


        PreOrder(root.left, targetSum, sum);
        PreOrder(root.right, targetSum, sum);

        if (!isRoot) return;

        PreOrder(root.left, targetSum, 0, isRoot);
        PreOrder(root.right, targetSum, 0, isRoot);
    }
    
}