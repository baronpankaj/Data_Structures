using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
   
   
            public class Node
        {
            public int data;
            public Node next;

            public Node(int i)
            {
                data = i;
            }

            public void Print()
            {
                Console.Write("|" + data + "|-->");

                if (next != null)
                {
                    next.Print();
                }
            }

            public void AddToEnd(int data)
            {
                if (next == null)
                {
                    next = new Node(data);
                }

                else
                {
                    next.AddToEnd(data);
                }
            }
        }

    }
