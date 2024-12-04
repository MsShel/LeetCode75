using LeetCode75.Scripts;

namespace LeetCode75;

public class Task199
{
    public Task199()
    {
        var testTree = TreeNode.ArrayToTree([1,2,3,null,5,null,4]);
        var testTree3 = TreeNode.ArrayToTree([1,2]);
        var testTree2 = TreeNode.ArrayToTree([]);
        var result = RightSideView(testTree3);
        foreach (var value in result)
        {
            Console.WriteLine(value);
        }
        
    }
    public IList<int> RightSideView(TreeNode root)
    {
        var resultDictionary = new Dictionary<int, int>();
        var queue = new Queue<(TreeNode, int)>();
        int level = 0;
        queue.Enqueue((root, level));

        while (queue.Count > 0)
        {
            if (queue.Count < 1)
            {
                break;
            }

            (var current, level) = queue.Dequeue();

            if (current == null)
            {
                continue;
            }

            resultDictionary[level] =  current.val;

            if (current.left != null)
            {
                queue.Enqueue((current.left, level + 1));
            }

            if (current.right != null)
            {
                queue.Enqueue((current.right, level + 1));
            }

        }

        return resultDictionary.Select(value => value.Value).ToList();
    }
}