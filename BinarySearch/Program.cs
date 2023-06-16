using BinarySearch;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BinarySearchTree<int> bst = new BinarySearchTree<int>();

        bst.Add(56);
        bst.Add(30);
        bst.Add(70);
        bst.Add(96);
        bst.Add(37);
        bst.Add(88);

        // Perform any additional operations on the BST as needed

        Console.WriteLine("Binary Search Tree created successfully!");
    }
}
