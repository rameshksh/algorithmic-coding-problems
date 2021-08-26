using CodingProblems.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    //Reversal of Linked List in groups of K.
    public class ReverseLinkedList
    {
        public void Run(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(new Node(85));
            list.AddNode(new Node(15));
            list.AddNode(new Node(4));
            list.AddNode(new Node(20));

            // List before reversal
            Console.WriteLine("Given linked list:");
            list.PrintList();

            // Reverse the list
            list.ReverseList();

            // List after reversal
            Console.WriteLine("Reversed linked list:");
            list.PrintList();
        }
    }   
}
