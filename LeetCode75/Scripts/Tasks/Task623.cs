namespace LeetCode75.Scripts.Tasks;

public class Task623
{
    public Task623()
    {
        var root = TreeNode.ArrayToTree([4, 2, 6, 3, 1, 5]);
        var val = 1;
        var depth = 2;

        AddOneRow(root, val, depth);
    }

    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if (depth == 1)
        {
            var newThree = new TreeNode
            {
                val = val,
                left = root
            };

            return newThree;
        }

        var queue = new Queue<(TreeNode tree, int level)>();
        queue.Enqueue((root, 1));

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node.level + 1 > depth)
            {
                break;
            }

            if (node.level + 1 == depth)
            {
                var leftChild = new TreeNode(val);
                leftChild.left = node.tree.left;
                node.tree.left = leftChild;

                var rightChild = new TreeNode(val);
                rightChild.right = node.tree.right;
                node.tree.right = rightChild.right;

                continue;
            }

            if (node.tree.left != null) queue.Enqueue((node.tree.left, node.level + 1));
            if (node.tree.right != null) queue.Enqueue((node.tree.right, node.level + 1));
        }

        return root;
    }
}