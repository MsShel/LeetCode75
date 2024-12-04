namespace LeetCode75.Scripts;

public class Task1448
{
    public Task1448()
    {
        var tree = TreeNode.ArrayToTree([3,1,4,3,null,1,5]);
        var tree2 = TreeNode.ArrayToTree([3,3,null,4,2]);
        var tree3 = TreeNode.ArrayToTree( [2, null, 4, 10, 8, null, null, 4]);
        Console.WriteLine(GoodNodes(tree));
    }

    public int GoodNodes1(TreeNode root)
    {
        var goodNodesAmount = 0;
        var treeStack = new Stack<(TreeNode, int)>();
        treeStack.Push((root,  root.val));

        while (treeStack.Count > 0)
        {
            var (currentRoot, path) = treeStack.Pop();

            if (path <= currentRoot.val)
            {
                goodNodesAmount ++;
                path = currentRoot.val;
            }

            if (currentRoot.right != null)
            {
                treeStack.Push((currentRoot.right, path));
            }
            if (currentRoot.left != null)
            {
                treeStack.Push((currentRoot.left, path));
            }
        }

        return goodNodesAmount;
    }

   
        public int GoodNodes(TreeNode? root, TreeNode? parent = null)
        {
            if (root is null)
                return 0;

            if (root.val >= (parent?.val ?? int.MinValue))
                return 1 + GoodNodes(root.left, root) + GoodNodes(root.right, root); // Add 1 to the result and pass the 'current root' as the parent (becuase it its the heighst node in the path now).

            return GoodNodes(root.left, parent) + GoodNodes(root.right, parent); // Pass the 'current parent' as it is (becuase it still the heighst node in the path till now).
        }
    
}