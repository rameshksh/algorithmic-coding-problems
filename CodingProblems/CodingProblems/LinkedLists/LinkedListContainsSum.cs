using System;
using System.Text;

namespace CodingProblems
{
    //Given two linked lists both represent a number. Create a linked list that contains its sum.

    class LinkedListSum
    {
        Node head1, head2;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        /* Adds contents of two linked lists
        and return the head node of resultant list */
        Node addTwoLists(Node first, Node second)
        {
            // res is head node of the resultant list
            Node res = null;
            Node prev = null;
            Node temp = null;
            int carry = 0, sum;

            // while both lists exist
            while (first != null || second != null)
            {
                // Calculate value of next digit in resultant
                // list. The next digit is sum of following
                // things (i) Carry (ii) Next digit of first
                // list (if there is a next digit) (ii) Next
                // digit of second list (if there is a next
                // digit)
                sum = carry + (first != null ? first.data : 0)
                      + (second != null ? second.data : 0);

                // update carry for next calculation
                carry = (sum >= 10) ? 1 : 0;

                // update sum if it is greater than 10
                sum = sum % 10;

                // Create a new node with sum as data
                temp = new Node(sum);

                // if this is the first node then set it as head
                // of the resultant list
                if (res == null)
                {
                    res = temp;
                }

                // If this is not the first
                // node then connect it to the rest.
                else
                {
                    prev.next = temp;
                }

                // Set prev for next insertion
                prev = temp;

                // Move first and second pointers to next nodes
                if (first != null)
                {
                    first = first.next;
                }
                if (second != null)
                {
                    second = second.next;
                }
            }

            if (carry > 0)
            {
                temp.next = new Node(carry);
            }

            // return head of the resultant list
            return res;
        }
        /* Utility function to print a linked list */

        void printList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
            Console.WriteLine("");
        }

        // Driver code
        public void Run(String[] args)
        {
            LinkedListSum list = new LinkedListSum();

            // creating first list
            list.head1 = new Node(7);
            list.head1.next = new Node(5);
            list.head1.next.next = new Node(9);
            list.head1.next.next.next = new Node(4);
            list.head1.next.next.next.next = new Node(6);
            Console.Write("First List is ");
            list.printList(list.head1);

            // creating seconnd list
            list.head2 = new Node(8);
            list.head2.next = new Node(4);
            Console.Write("Second List is ");
            list.printList(list.head2);

            // add the two lists and see the result
            Node rs = list.addTwoLists(list.head1, list.head2);
            Console.Write("Resultant List is ");
            list.printList(rs);
        }
    }
}
