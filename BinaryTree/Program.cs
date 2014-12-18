using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using snipd;

namespace binarytree
{
    class Program
    {
        static void Main(string[] args)
        {


            // Initialize a BST which will contain integers
            BinarySearchTree<int> intTree = new BinarySearchTree<int>();

            Random r = new Random(DateTime.Now.Millisecond);
            string trace = "";

            // Insert 5 random integers into the tree
            /*for (int i = 0; i < 15; i++)
            {
                int randomInt = r.Next(1, 500);
                intTree.Insert(randomInt);
                trace += randomInt + " ";
            }*/

            intTree.Insert(3);
            intTree.Insert(1);
            intTree.Insert(5);
            intTree.Insert(2);
            intTree.Insert(4);
            intTree.Insert(6);
            intTree.Insert(0);

            // Find the largest value in the tree
            Console.WriteLine("Max: " + intTree.FindMax());

            // Find the smallest value in the tree
            Console.WriteLine("Min: " + intTree.FindMin());

            // Find the root of the tree
            Console.WriteLine("Root: " + intTree.Root.Element);

            // The order in which the elements were added to the tree
            Console.WriteLine("Trace: " + trace);

            // A textual representation of the tree
            Console.WriteLine("Tree: " + intTree);

            Console.ReadLine();
        }
    }
}
