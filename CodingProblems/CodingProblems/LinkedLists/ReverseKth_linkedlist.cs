using CodingProblems.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.LinkedLists
{
    public class ReverseKth_linkedlist
    {      

        public void Run(String[] args)
        {
            LinkedList llist = new LinkedList();

            /* Constructed Linked List is 1->2->3->4->5->6->
            7->8->8->9->null */
            llist.push(9);
            llist.push(8);
            llist.push(7);
            llist.push(6);
            llist.push(5);
            llist.push(4);
            llist.push(3);
            llist.push(2);
            llist.push(1);

            Console.WriteLine("Given Linked List");
            llist.PrintList();

            llist.head = llist.reverse(llist.head, 3);

            Console.WriteLine("Reversed list");
            llist.PrintList();
        }
    }
}
