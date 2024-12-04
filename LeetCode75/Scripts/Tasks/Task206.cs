namespace LeetCode75.Scripts;

public class Task206
{
    public Task206()
    {
        var lnkedLis1 = ListNode.FromArray([1, 2, 3, 4, 5]);
        Console.WriteLine(ReverseList(lnkedLis1));
    }

    public ListNode ReverseList(ListNode head)
    {
        var tempNext = head;
        var current = head;
        ListNode newNode = null;

        while (current is not null)
        {
            tempNext = current.next;  
            current.next = newNode;
            newNode = current;
            current = tempNext;
        }  

        return newNode;
    }
}