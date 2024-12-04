namespace LeetCode75.Scripts;

public class Task450
{
    public static int A = 1;
    public Task450()
    {
        A = 3;
        var tree = TreeNode.ArrayToTree([5, 3, 6, 2, 4, null, 7]);
        var val = 3;
        //var res = DeleteNode(tree, val);

        // var a = FuncFactory(10);
        // Console.WriteLine(a(80));
    }
    

    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
        {
            return null;
        }

        TreeNode parent = null;
        TreeNode current = root;

        // Этап 1: Найти узел для удаления
        while (current != null && current.val != key)
        {
            parent = current;
            current = key < current.val ? current.left : current.right;
        }

        // Если узел не найден, возвращаем дерево
        if (current == null)
        {
            return root;
        }

        // Этап 2: Удаление узла
        if (current.left == null || current.right == null)
        {
            // Узел имеет 0 или 1 ребёнка
            TreeNode replacement = current.left ?? current.right;

            if (parent == null)
            {
                // Если удаляем корень
                return replacement;
            }

            // Связываем родителя с заменой
            if (parent.left == current)
            {
                parent.left = replacement;
            }
            else
                parent.right = replacement;
        }
        else
        {
            // Узел имеет двух детей
            // Найти минимальный узел в правом поддереве
            TreeNode successorParent = current;
            TreeNode successor = current.right;

            while (successor.left != null)
            {
                successorParent = successor;
                successor = successor.left;
            }

            // Заменяем значение текущего узла значением преемника
             current.val = successor.val;

            // Удаляем преемника
            if (successorParent.left == successor)
            {
                successorParent.left = successor.right;
            }
            else
                successorParent.right = successor.right;
           
        }

        // Возвращаем обновлённое дерево
        return root;
    }

    // public TreeNode DeleteNode(TreeNode root, int key)
    // {
    //     var parent = new TreeNode();
    //     var currentRoot = new TreeNode();
    //
    //     var treeStack = new Stack<TreeNode>();
    //     treeStack.Push(root);
    //
    //     while (treeStack.Count > 0)
    //     {
    //         currentRoot = treeStack.Pop();
    //
    //         if (currentRoot.val == key)
    //         {
    //             break;
    //         }
    //
    //         if (currentRoot.left != null && currentRoot.val > key)
    //         {
    //             treeStack.Push(currentRoot.left);
    //         }
    //         else if (currentRoot.right != null)
    //         {
    //             treeStack.Push(currentRoot.right);
    //         }
    //
    //         parent = currentRoot;
    //     }
    //
    //     if (currentRoot.right != null)
    //     {
    //         treeStack.Push(currentRoot);
    //     }
    //
    //     var secondOfMin = new TreeNode();
    //     while (treeStack.Count > 0)
    //     {
    //         currentRoot = treeStack.Pop();
    //
    //         if (currentRoot.left == null)
    //         {
    //             break;
    //         }
    //
    //         treeStack.Push(currentRoot.left);
    //         secondOfMin = currentRoot;
    //     }
    //
    //     secondOfMin = currentRoot.right ?? null;
    //     parent = currentRoot;
    //     
    //     return root;
    // }

    public static Func<int, int> FuncFactory(int num)
    {
        return x => num * x;
    }
}