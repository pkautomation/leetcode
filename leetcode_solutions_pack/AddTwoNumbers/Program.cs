// https://leetcode.com/problems/add-two-numbers/

using System.Numerics;

//Definition for singly - linked list.

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        string firstNumberReversed = "";
        string secondNumberReversed = "";

        while (l1 != null)
        {
            var currentNode = l1;
            firstNumberReversed += l1.val;
            l1 = currentNode.next;
        }

        while (l2 != null)
        {
            var currentNode = l2;
            secondNumberReversed += l2.val;
            l2 = currentNode.next;
        }

        string num1string = string.Join("", firstNumberReversed.Reverse().ToArray());
        string num2string = string.Join("", secondNumberReversed.Reverse().ToArray());

        string additionResult = string.Join("", (System.Numerics.BigInteger.Parse(num1string) + System.Numerics.BigInteger.Parse(num2string)).ToString().Reverse().ToArray());

        ListNode node = new ListNode(int.Parse(additionResult[0].ToString()), null);

        for(int i = 1; i < additionResult.Length; i++)
        {
            insertRef(ref node, int.Parse(additionResult[i].ToString()));
        }

        return node;
    }

    public static void insertRef(ref ListNode original, int val)
    {
        if (original != null)
        {
            insertRef(ref original.next, val);
        }
        else
        {
            original = new ListNode(val, null);
        }
    }

    //972
    public static void Main()
    {
        AddTwoNumbers(
            new ListNode(1, new(2, new(3, null))),
            new ListNode(1, new(5, new(6, null)))
        );
    }
}

