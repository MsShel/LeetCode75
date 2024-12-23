namespace LeetCode75.Scripts.Tasks;

public class Task100
{
    public Task100()
    {
        var p = TreeNode.ArrayToTree([1, 2]);
        var q = TreeNode.ArrayToTree([1, null, 2]);
        Console.WriteLine(IsSameTree(p, q));
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        var firstTree = new Stack<TreeNode>();
        firstTree.Push(p);
        var secondTree = new Stack<TreeNode>();
        secondTree.Push(q);

        while (firstTree.Count > 0 && firstTree.Count == secondTree.Count)
        {
            var nodeP = firstTree.Pop();
            var nodeQ = secondTree.Pop();

            if (nodeP == null && nodeQ == null)
            {
                continue;
            }

            if (nodeP == null || nodeQ == null || nodeP.val != nodeQ.val)
            {
                return false;
            }

            firstTree.Push(nodeP.left);
            secondTree.Push(nodeQ.left);
            firstTree.Push(nodeP.right);
            secondTree.Push(nodeQ.right);
        }

        return true;
    }
}