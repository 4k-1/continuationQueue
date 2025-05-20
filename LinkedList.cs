using System;
using System.Collections.Generic;

public class LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data) 
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;
    private int currentNumber;

    public LinkedList(int startNumber)
    {
        currentNumber = startNumber;
        head = null;
    }

    public void Enqueue()
    {
        Node newNode = new Node(currentNumber++);
        if (head == null)
            head = newNode;
        else
        {
            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newNode;
        }
    }

    public void Dequeue()
    {
        if (head != null)
            head = head.Next;
    }

    public List<int> ToList()
    {
        List<int> result = new List<int>();
        Node temp = head;
        while (temp != null)
        {
            result.Add(temp.Data);
            temp = temp.Next;
        }
        return result;
    }
    public int PeekLast()
    {
        Node temp = head;
        if (temp == null) return -1;

        while (temp.Next != null)
            temp = temp.Next;

        return temp.Data;
    }


}
