// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net.Sockets;
using Microsoft.VisualBasic.FileIO;

using pairingsession_josh_281022;

public class BinarySearchTree
{
    public Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public int acceptInput()
    {
        Console.WriteLine("Please enter a number");
        var val = Console.ReadLine();
        var val2 = int.Parse(val);
        return val2;
    }
    public void add()
    {
        insert(acceptInput());
    }
    public void getUserInput()
    {
        bool cont = true;
        do
        {
            Console.WriteLine("Press 1 to add an element to the tree.");
            Console.WriteLine("Press 2 to search an element in the tree.");
            Console.WriteLine("Press 3 to print out to the tree.");
            Console.WriteLine("Press 4 to exit.");
            Console.WriteLine("Press 0 to fill.");

            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    add();
                    break;
                case "2":
                    Console.WriteLine(searchAlgo(int.Parse(Console.ReadLine()), root));
                    break;
                case "3":
                    display();
                    break;
                case "4":
                    Console.WriteLine("Exiting, goodbye!");
                    cont = false;
                    break;
                default:
                    Console.WriteLine("Unrecognised input. Ignoring!");
                    break;
            }
        } while (cont);
    }

    public void insert(int data)
    {
        Node newNode = new Node(data);

        if (root == null)
        {
            root = newNode;
            return;
        }
        else
        {
            Node current = root;
            Node parent = null;

            while (true)
            {
                parent = current;

                if (data < current.data)
                {
                    current = current.left;
                    if (current == null)
                    {
                        parent.left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.right;
                    if (current == null)
                    {
                        parent.right = newNode;
                        return;
                    }
                }
            }
        }
    }

    public void display()
    {
        inorderTraversal(root);
        Console.WriteLine();
    }
    
    public void inorderTraversal(Node node) 
    {  
        if (root == null)
        {  
            Console.WriteLine("Tree is empty");  
            return;  
        }  
        else 
        {  
            if(node.left!= null)  
                inorderTraversal(node.left);  
            Console.WriteLine(node.data + " ");  
            if(node.right!= null)  
                inorderTraversal(node.right);  
        }  
    }

    public bool SearchAlgoIterative(int data)
    {
        Node current = root;
        while (current != null)
        {
            if (data == current.data)
            {
                return true;
            }
            else if (data < current.data)
            {
                current = current.left;
            }
            else
            {
                current = current.right;
            }
        }
        return false;
    }
    
    public bool searchAlgo(int data, Node testNode)
    {
        if (testNode.data == data)
        {
            return true;
        }
        else if (data < testNode.data)
        {
            if (testNode.left == null) return false;
            else
            {
                return searchAlgo(data, testNode.left);
            }
        }
        else
        {
            if (testNode.right == null) return false;
            else
            {
                return searchAlgo(data, testNode.right);
            }
        }

        return false;
    }
}



/*
 
// Start timer
var watch = Stopwatch.StartNew();


// Stop timer
watch.Stop();   
var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine("Time: " + elapsedMs);

*/