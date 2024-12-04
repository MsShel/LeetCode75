namespace LeetCode75.Scripts;

public class Task236
{
    public List<TreeNode> _pathToGivenNode = new();

    public Task236()
    {
        var tree = TreeNode.ArrayToTree([3, 5, 1, 6, 2, 0, 8, null, null, 7, 4]);
        var p = 5;
        var q = 1;
        
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
            if (root == null)
            {
                return null;
            }

            if (root == p || root == q)
            {
                return root;
            }

            var first = LowestCommonAncestor(root.left, p, q);
            var second = LowestCommonAncestor(root.right, p, q);

            if (first != null && second != null)
            {
                return root;
            }

            return first ?? second;
        }
}