namespace LeetCode75.Scripts;

public class Task700
{
    public Task700()
    {
        var tree = TreeNode.ArrayToTree([4, 2, 7, 1, 3]);
        var val = 2;
        Console.WriteLine(SearchBST(tree, val).val);
    }

    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null)
        {
            return null;
        }

        var treeStack = new Stack<TreeNode>();
        treeStack.Push(root);

        while (treeStack.Count > 0)
        {
            var currenRoot = treeStack.Pop();

            if (currenRoot.val == val)
            {
                return currenRoot;
            }

            if (currenRoot.left != null)
            {
                treeStack.Push(currenRoot.left);
            }

            if (currenRoot.right != null)
            {
                treeStack.Push(currenRoot.right);
            }
        }

        return null;
    }
}