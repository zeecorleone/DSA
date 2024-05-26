

namespace DSA.Host.Linklist;

internal class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }

    public Node() { }

    public void Insert(Node head, int data, int pos)
    {
        Node toAdd = new Node(data);

        if (pos == 0)
        {
            toAdd.Next = head;
            head = toAdd;
            return;
        }

        Node prev = head;
        for (int i = 0; i < pos - 1; i++)
        {
            prev = prev.Next;
        }

        toAdd.Next = prev.Next;
        prev.Next = toAdd;
    }

    public void DeleteByPosition(Node head, int pos)
    {
        if (pos == 0)
        {
            head = head.Next;
            return;
        }

        Node prev = head;
        for(int i = 0; i < pos - 1; i++)
        {
            prev = prev.Next; 
        }

        prev.Next = prev.Next.Next;
    }

    public void DeleteByValue(Node head, int data)
    {
        if(head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node pointer = head;
        while(pointer != null)
        {
            if (pointer.Next != null && pointer.Next.Data == data)
            {
                pointer.Next = pointer.Next.Next;
                break;
            }
            pointer = pointer.Next;

        }
    }

    public void Display(Node head)
    {
        var item = head;
        string result = "";
        while (item != null)
        {
            result += item.Data + ", ";
            item = item.Next;
        }

        if(!string.IsNullOrWhiteSpace(result))
            Console.WriteLine(result.TrimEnd(',', ' '));
    }

    public void Run()
    {

        Console.WriteLine("***** Running Link List ****");
        var n1 = new Node(0);
        var n2 = new Node(1);
        n1.Next = n2;

        var n3 = new Node(2);
        n2.Next = n3;

        var n4 = new Node(3);
        n3.Next = n4;

        var n5 = new Node(4);
        n4.Next = n5;

        var head = n1;

        Display(head);

        Insert(head, 5, 5);

        Display(head);

        DeleteByPosition(head, 4);

        Display(head);

        DeleteByValue(head, 2);

        Display(head);
        Console.WriteLine("******** DONE ********");

    }
}

