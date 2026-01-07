using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a LinkedList
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        list.AddLast(40);

        // Search for a value
        int valueToFind = 30;
        bool found = Search(list, valueToFind);

        if (found)
            Console.WriteLine($"{valueToFind} is found in the list.");
        else
            Console.WriteLine($"{valueToFind} is not found in the list.");


		Console.WriteLine("Original Linked List:");
        PrintList(list);

        // Sort the LinkedList
        list = SortLinkedList(list);

        Console.WriteLine("\nSorted Linked List:");
        PrintList(list);
 
		// Remove a specific value
        list.Remove(20);

        // Remove the first node
        list.RemoveFirst();

        // Remove the last node
        list.RemoveLast();

        Console.WriteLine("\nLinked List after Deletions:");
        PrintList(list);

// Create a LinkedList
        LinkedList<int> list1 = new LinkedList<int>();

        // Insert at the end
        list1.AddLast(10);
        list1.AddLast(20);
        list1.AddLast(30);

        // Insert at the beginning
        list1.AddFirst(5);

        // Insert after a specific node
        LinkedListNode<int> node = list1.Find(20);
        if (node != null)
        {
            list1.AddAfter(node, 25);
        }

        // Insert before a specific node
        node = list1.Find(10);
        if (node != null)
        {
            list1.AddBefore(node, 8);
        }

        Console.WriteLine("Linked List after Insertions:");
        PrintList(list1);

    }

    static bool Search(LinkedList<int> list, int value)
    {
        foreach (int nodeValue in list)
        {
            if (nodeValue == value)
                return true;
        }
        return false;
    }
    

    static LinkedList<int> SortLinkedList(LinkedList<int> list)
    {
        // Convert LinkedList to List
        List<int> tempList = new List<int>(list);

        // Sort the list
        tempList.Sort();

        // Rebuild the LinkedList from sorted list
        LinkedList<int> sortedList = new LinkedList<int>(tempList);
        return sortedList;
    }

    static void PrintList(LinkedList<int> list)
    {
        foreach (int value in list)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}

