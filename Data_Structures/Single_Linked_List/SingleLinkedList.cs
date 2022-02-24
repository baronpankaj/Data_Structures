using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class SingleLinkedList
    {
        public Node headNode, start;

        public SingleLinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Console.WriteLine(headNode.data);
                headNode.AddToEnd(data);
            }
        }

        public void Print()
        {


            if (headNode != null)
            {
                headNode.Print();
            }
        }

        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Console.WriteLine(headNode.data);
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;

            }
        }

        public void CreateList()
        {
            Console.WriteLine("Please enter the number of Nodes");
            int nodes = Int32.Parse(Console.ReadLine());
            for(int i = 1; i<= nodes; i++)
            {
                Console.WriteLine("Please enter the value of the node " + i.ToString());
                AddToEnd(Int32.Parse(Console.ReadLine()));
            }
            
        }
        public void countNodes()
        {
            int count = 0;
            start = headNode;
            while(headNode!=null)
            {
                headNode = headNode.next;
                count++;
            }
            Console.WriteLine("The number of nodes is " + count.ToString());
            headNode = start;
        }
        public void searchElement(int data)
        {
            int position = 1;
            bool found = false;
            start = headNode;
            if (headNode == null)
            {
                Console.WriteLine("There are no nodes in the list");
            }
            else 
            {
                while (headNode != null)
                {

                    if(headNode.data == data)
                    {
                        Console.WriteLine("The data is at the node " + position.ToString());
                        found = true;
                        break;
                    }
                    headNode = headNode.next;
                    position++;
                }
                if(found == false)
                {
                    Console.WriteLine("The value is not present in the list");
                }

            }
            headNode = start;
            
        }

        public void insertafter(int value, int nodeVal)
        {
            start = headNode;
            if (headNode == null)
            {
                Console.WriteLine("There are no nodes in the list");
            }
            else
            {
                while (headNode != null)
                {

                    if (headNode.data == value)
                    {
                        Node temp = new Node(nodeVal);
                        temp.next = headNode.next;
                        headNode.next = temp;
                        break;
                    }
                    headNode = headNode.next;
                    
                }
                

            }
            headNode = start;

        }

        public void insertbefore(int value, int nodeVal)
        {
            start = headNode;
            if (headNode == null)
            {
                Console.WriteLine("There are no nodes in the list");
            }
            else
            {
                while (headNode != null)
                {

                    if (headNode.next.data == value)
                    {
                        Node temp = new Node(nodeVal);
                        temp.next = headNode.next;
                        headNode.next = temp;
                        break;
                    }
                    headNode = headNode.next;

                }


            }
            headNode = start;

        }

        public void insertatposition(int position, int data)
        {
            start = headNode;
            int initialposition = 1;
            bool found = false;
            start = headNode;
            if (headNode == null)
            {
                Console.WriteLine("There are no nodes in the list");
            }
            else
            {
                while (headNode != null)
                {

                    if (initialposition  == position)
                    {
                        Node temp = new Node(data);
                        temp.next = headNode.next;
                        headNode = temp;
                        found = true;
                        break;
                    }
                    headNode = headNode.next;
                    initialposition++;
                }
                if (found == false)
                {
                    Console.WriteLine("The value is not present in the list");
                }
                headNode = start;
            }
            headNode = start;

        }

    }
}
