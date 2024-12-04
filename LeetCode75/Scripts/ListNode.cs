namespace LeetCode75.Scripts;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    // Статический метод, создающий связанный список из массива и возвращающий голову
    public static ListNode FromArray(int[] values)
    {
        if (values == null || values.Length == 0)
            return null;

        // Создаем голову списка
        ListNode head = new ListNode(values[0]);
        ListNode current = head;

        // Строим оставшуюся часть списка
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }
}