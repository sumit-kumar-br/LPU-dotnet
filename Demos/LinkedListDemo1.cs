using System;

public class Node
{
	public int data;
	public Node next;
}

public static class Globals
{
	public static Node head;

	public static void insertNode(int idata)
	{
		Node tmp = new Node();
		tmp.data = idata;
		tmp.next = null;

		if (head == null)
		{
			head = tmp;
		}
		else
		{
			tmp.next = head;
			head = tmp;
		}
	}

	public static void append(int idata)
	{
		Node tmp = new Node();
		tmp.data = idata;
		tmp.next = null;

		if (head == null)
		{
			head = tmp;
		}
		else
		{
			Node it = head;
			while (it.next != null)
			{
				it = it.next;
			}
			it.next = tmp;
		}
	}

	public static void printLL()
	{
		Node it = head;
		while (it != null)
		{
			Console.Write(it.data);
			Console.Write("-->");
			it = it.next;
		}
		Console.WriteLine();
	}

	public static void remove()
	{
		if (head != null)
		{
			if (head.next == null)
			{
				head = null;
				head = null;
			}
			else
			{
				Node t = head.next;
				head = null;
				head = t;
			}

		}
	}

	internal static void Main()
	{
		insertNode(10);
		insertNode(15);
		append(30);
		insertNode(25);

		printLL();
		remove();
		remove();
		append(30);
		printLL();
		system("pause");
	}




}
