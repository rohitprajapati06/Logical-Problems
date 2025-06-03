using System;

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

public class SinglyLinkedList
{
    private Node head;

    // Add a node at the end
    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    // Add a node at the beginning
    public void AddFirst(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    // Delete a node by value
    public void Delete(int data)
    {
        if (head == null) return;

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null && current.Next.Data != data)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // Search for a value
    public bool Search(int value)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == value)
                return true;
            current = current.Next;
        }
        return false;
    }

    // Count the number of nodes
    public int Count()
    {
        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // Print the list
    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

public class Program
{
    public static void Main()
    {
        SinglyLinkedList list = new SinglyLinkedList();

        list.AddLast(10);
        list.AddLast(20);
        list.AddFirst(5);
        list.PrintList();  // Output: 5 -> 10 -> 20 -> null

        list.Delete(10);
        list.PrintList();  // Output: 5 -> 20 -> null

        Console.WriteLine("Contains 20? " + list.Search(20));  // true
        Console.WriteLine("Total Nodes: " + list.Count());     // 2
    }
}
