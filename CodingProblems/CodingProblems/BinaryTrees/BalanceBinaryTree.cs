using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{

    //Check whether given binary tree is balanced or not. 
    //Definition was no two leaves should have height difference of greater than one.
    class BalanceBinaryTree
    {
        public void run() {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.left.left.left = new Node(8);

            if (tree.isBalanced(tree.root))
            {
                Console.WriteLine("Tree is balanced");
            }
            else
            {
                Console.WriteLine("Tree is not balanced");
            }
        }
    }

    public class BinaryTree
    {
        public Node root;

        /* Returns true if binary tree with root as
        root is height-balanced */
        public virtual bool isBalanced(Node node)
        {
            int lh; // for height of left subtree
            int rh; // for height of right subtree

            /* If tree is empty then return true */
            if (node == null)
            {
                return true;
            }

            /* Get the height of left and right sub trees */
            lh = height(node.left);
            rh = height(node.right);

            if (Math.Abs(lh - rh) <= 1 && isBalanced(node.left)
                && isBalanced(node.right))
            {
                return true;
            }

            /* If we reach here then tree is not height-balanced */
            return false;
        }

        /* UTILITY FUNCTIONS TO TEST isBalanced() FUNCTION */
        /* The function Compute the "height" of a tree.
         * 
         * Height is the number of nodes along the longest path from the root node
            down to the farthest leaf node.
        */
        public virtual int height(Node node)
        {
            /* base case tree is empty */
            if (node == null)
            {
                return 0;
            }

            /* If tree is not empty then height = 1 + max of left height and right heights */
            return 1 + Math.Max(height(node.left), height(node.right));
        }
    }

    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }

}
