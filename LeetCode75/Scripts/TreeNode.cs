namespace LeetCode75.Scripts;

// Got it from leetcode.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    
    // Static method to convert an array to a TreeNode
    public static TreeNode ArrayToTree(int?[] arr) {
        if (arr == null || arr.Length == 0 || arr[0] == null) return null;

        TreeNode root = new TreeNode(arr[0].Value);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int i = 1;
        while (i < arr.Length) {
            TreeNode current = queue.Dequeue();

            // Set left child
            if (i < arr.Length && arr[i] != null) {
                current.left = new TreeNode(arr[i].Value);
                queue.Enqueue(current.left);
            }
            i++;

            // Set right child
            if (i < arr.Length && arr[i] != null) {
                current.right = new TreeNode(arr[i].Value);
                queue.Enqueue(current.right);
            }
            i++;
        }

        return root;
    }
}