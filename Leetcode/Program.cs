using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();

            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(2);
            LinkedListNode<int> node5 = new LinkedListNode<int>(3);
            LinkedListNode<int> node6 = new LinkedListNode<int>(6);

            list1.AddFirst(node1);
            list1.AddLast(node2);
            list1.AddLast(node3);

            list2.AddFirst(node4);
            list2.AddLast(node5);
            list2.AddLast(node6);

            LinkListSolutions.MergeTwoLinkList(list1, list2);





        }
    }
}
