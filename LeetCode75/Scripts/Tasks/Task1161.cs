namespace LeetCode75.Scripts;

public class Task1161
{
    public Task1161()
    {
        var tree = TreeNode.ArrayToTree([1, 7, 0, 7, -8, null, null]);
        var tree2 = TreeNode.ArrayToTree([989,null,10250,98693,-89388,null,null,null,-32127]);
        Console.WriteLine(MaxLevelSum(tree2));
    }

    public int MaxLevelSum(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var resultLevel = 1;
        var maxLevelSum = root.val;
        var currentLevel = 1;
        var currentLevelSum = maxLevelSum;


        var treeQueue = new Queue<(TreeNode treeRoot, int level)>();
        treeQueue.Enqueue((root, 1));

        while (treeQueue.Count > 0)
        {
            var (node, level) = treeQueue.Dequeue();

            if (level > currentLevel)
            {
                if (maxLevelSum < currentLevelSum)
                {
                    maxLevelSum = currentLevelSum;
                    resultLevel = currentLevel;
                }

                currentLevel = level;
                currentLevelSum = 0;
            }

            currentLevelSum += node.val;

            if (node.left != null)
            {
                treeQueue.Enqueue((node.left, currentLevel + 1));
            }

            if (node.right != null)
            {
                treeQueue.Enqueue((node.right, currentLevel + 1));
            }
        }

        if (maxLevelSum < currentLevelSum)
        {
            resultLevel = currentLevel;
        }

        return resultLevel;
    }
}