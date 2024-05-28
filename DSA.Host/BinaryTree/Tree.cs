
namespace DSA.Host.BinaryTree;

internal class TreeHelper
{
    //             Sample Tree
    //             ______2______
    //       _____4____     ____1
    //   ____7        10    4
    //  6
    //
    //
    private Node CreateTree()
    {
        Node root = null;

        Console.WriteLine("Enter data: ");
        int data = int.Parse(Console.ReadLine());

        if (data == -1)
            return null;

        root = new Node(data);
        
        Console.WriteLine("Enter left for " + data);
        root.Left = CreateTree();

        Console.WriteLine("Enter right for " + data);
        root.Right = CreateTree();


        return root;
    }

    /// <summary>
    /// Prints in order Left-Node-Right (LNR)
    /// </summary>
    /// <param name="root"></param>
    private void InOrderDisplay(Node root)
    {
        if(root == null)
            return;

        InOrderDisplay(root.Left);
        Console.Write(root.data + ", ");
        InOrderDisplay(root.Right);
    }

    /// <summary>
    /// Prints in order NLR
    /// </summary>
    /// <param name="root"></param>
    private void preOrderDisplay(Node root)
    {
        if(root == null)
            return;

        Console.Write(root.data + ", ");
        preOrderDisplay(root.Left);
        preOrderDisplay(root.Right);
    }

    /// <summary>
    /// Prints in order LRN
    /// </summary>
    /// <param name="root"></param>
    private void postOrderDisplay(Node root)
    {
        if (root == null)
            return;
        postOrderDisplay(root.Left);
        postOrderDisplay(root.Right);
        Console.Write(root.data + ", ");
    }

    public void Run()
    {
        var tree = CreateTree();

        Console.WriteLine("Printing InOrder..");
        InOrderDisplay(tree);
        Console.WriteLine("");

        Console.WriteLine("Printing PreOrder..");
        preOrderDisplay(tree);
        Console.WriteLine("");

        Console.WriteLine("Printing PostOrder..");
        postOrderDisplay(tree);
        Console.WriteLine("");

        Console.WriteLine("Height of Tree is: ");
        Console.WriteLine(GetHeight(tree) + "\n");

    }

    private int GetHeight(Node root)
    {
        if (root == null)
            return 0;

        return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;
    }
}

internal class Node
{
    public int data;

    public Node(int data)
    {
        this.data = data;
    }

    public Node Left { get; set; }
    public Node Right { get; set; }
}