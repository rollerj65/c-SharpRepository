//https://www.csharpstar.com/csharp-program-to-implement-binary-search-tree/
//A binary tree is defined as a tree where each node can have no more than two children. By limiting the number of children to 2, we can write efficient programs for inserting data, deleting data, and searching for data in a binary tree.

//Once we’re inside the BST, the next step is to determine where to put the new node.This is performed inside a while loop that we break once we’ve found the correct position for the new node.The algorithm for determining the proper position for a node is as follows:
 
//1. Set the parent node to be the current node, which is the root node.
//2. If the data value in the new node is less than the data value in the current node, set the current node to be the left child of the current node.If the data value in the new node is greater than the data value in the current node, skip to Step 4.
//3. If the value of the left child of the current node is null, insert the new node here and exit the loop.Otherwise, skip to the next iteration of the While loop.
//4. Set the current node to the right child node of the current node.
//5. If the value of the right child of the current node is null, insert the new node here and exit the loop.Otherwise, skip to the next iteration of the While loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree_BST_
{
    class binarySearchTree //uses class structure to to create tree. No clear visualization.
    {
        public class Node //each Node in the binary search tree is represented by a class (Node), with attributes for the value, node to the left of the given node, and to the right.
        {
            public int Data;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.Write(Data + " ");
            }
        }
        public Node root; //root node usually set to NULL
        public binarySearchTree()
        {
            root = null;// initialize root as null when BinarySearchTree is created.
        }

        public void Insert(int i)
        {
            Node newNode = new Node();// create new node and set node.data to input i
            newNode.Data = i;
            if (root == null)// if root is null (first time the class is called) then just create a new node and assign it to root.
            {
                root = newNode;
            }
            else// if this isn't the first time the class is called, then set the current node to root (top of the BinarySearchTree).
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;// for each iteration, set the parent value to the node above current. Current will be the node we are iterating through at any given moment.
                    Console.WriteLine(parent.Data + " is the current node");
                    if (i < current.Data) // if data is less than the current value, then set it to the left of the node.
                    {
                        Console.WriteLine("insert data: " + i + " is less than current data: " + current.Data + ". setting current data to the left of insert data: " + i );
                        current = current.Left;
                        if (current == null) //catch null, just in case. Create new node.
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Current data: " + i + " is greater than insert data: " + current.Data + ". setting current data to the right of insert data: " + i);
                        current = current.Right; //catch null, just in case. Create new node.
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            binarySearchTree nums = new binarySearchTree();
            nums.Insert(50);
            nums.Insert(17);
            nums.Insert(23);
            nums.Insert(12);
            nums.Insert(19);
            nums.Insert(54);
            nums.Insert(9);
            nums.Insert(14);
            nums.Insert(67);
            nums.Insert(76);
            nums.Insert(72);
            Console.ReadLine();
        }
    }
}
