namespace LeetCode75.Scripts.Tasks;

public class Task99
{
    public Task99()
    {
        var root = TreeNode.ArrayToTree([1, 3, null, null, 2]);
        RecoverTree(root);
    }

    private TreeNode _firstMistaken = null;
    private TreeNode _secondMistaken = null;
    private TreeNode _previous = null;

    public void RecoverTree(TreeNode root)
    {
        // RecursionInorderSearch(root);
        StackInorderSearch(root);
        (_firstMistaken.val, _secondMistaken.val) = (_secondMistaken.val, _firstMistaken.val);
    }

    private void StackInorderSearch(TreeNode root)
    {
        var treeStack = new Stack<TreeNode>();
        var current = root;

        while (treeStack.Count > 0 || current != null)
        {
            while (current != null)
            {
                treeStack.Push(current);
                current = current.left;
            }

            current = treeStack.Pop();

            if (_previous != null && current.val < _previous.val)
            {
                if (_firstMistaken == null)
                {
                    _firstMistaken = _previous;
                }

                _secondMistaken = current;
            }

            _previous = current;
            current = current.right;
        }
    }

    private void RecursionInorderSearch(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        RecursionInorderSearch(root.left);

        if (_previous != null && _previous.val > root.val)
        {
            if (_firstMistaken == null)
            {
                _firstMistaken = _previous;
            }

            _secondMistaken = root;
        }

        _previous = root;
        RecursionInorderSearch(root.right);
    }
}