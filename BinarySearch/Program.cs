using BinarySearch;

internal class Program
{
    private static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.Add(56);
        tree.Add(30);
        tree.Add(40);
        tree.Add(22);
        tree.Add(11);
        tree.Add(13);
        tree.Add(3);
        tree.Add(70);
        tree.Add(60);
        tree.Add(65);
        tree.Add(63);
        tree.Add(67);
        tree.Add(95);


        int size = tree.Size();
        Console.WriteLine("Size of the binary tree: " + size);

    }
}
