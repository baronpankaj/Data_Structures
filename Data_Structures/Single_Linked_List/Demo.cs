using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Demo
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();

            /*for(int x = 5; x<10; x++)
            {
                list.AddToEnd(x);
            }
            list.Print();
            Console.WriteLine();
            for (int x = 4; x > 0; x--)
            {
                list.AddToBeginning(x);
            }
            list.Print();*/

            /*list.AddToBeginning(8);
            list.AddToBeginning(17);
            list.AddToBeginning(3);
            list.AddToBeginning(22);
            list.AddToBeginning(7);
            list.Print();
*/
            list.CreateList();

            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an Element");
                Console.WriteLine("4. Insert in an empty list/Insert in the beginning of the list");
                Console.WriteLine("5. Insert a Node at the end of the list");
                Console.WriteLine("6. Insert a node after a specified node");
                Console.WriteLine("7. Insert a node before a specified node");
                Console.WriteLine("8. Insert a node at a certain position");
                Console.WriteLine("9. Delete First Node");
                Console.WriteLine("10. Delete last Node");
                Console.WriteLine("11. Delete any Node");
                Console.WriteLine("12. Reverse the List");
                Console.WriteLine(" 19. Quit");

                Console.WriteLine();
                Console.WriteLine("Enter your choice ?");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 19)
                    break;

                switch(choice)
                {
                    case 1:
                        list.Print();
                        break;

                    case 2:
                        list.countNodes();
                        break;

                    case 3:
                        Console.WriteLine("Enter the value to be searched");
                        int data = Int32.Parse(Console.ReadLine());
                        list.searchElement(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter the data for the node to be inserted in the beginning");
                        list.AddToBeginning(Int32.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("Enter the data for the node to be inserted at the end");
                        list.AddToEnd(Int32.Parse(Console.ReadLine()));
                        break;
                    case 6:
                        Console.WriteLine("Enter the value of node after which the new node is to be inserted");
                        int value = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the value of  new node");
                        int nodeVal = Int32.Parse(Console.ReadLine());
                        list.insertafter(value, nodeVal);
                        break;
                    case 7:
                        Console.WriteLine("Enter the value of node before which the new node is to be inserted");
                        int beforevalue = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the value of  new node");
                        int newnodeVal = Int32.Parse(Console.ReadLine());
                        list.insertbefore(beforevalue, newnodeVal);
                        break;
                    case 8:
                        Console.WriteLine("Enter the position of node at which the new node is to be inserted");
                        int position = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the value of  new node");
                        int posnodeVal = Int32.Parse(Console.ReadLine());
                        list.insertatposition(position, posnodeVal);
                        break;
                    case 9:
                        list.deletefirstnode();
                        break;

                    case 10:
                        list.deletelastnode();
                        break;
                    case 11:
                        Console.WriteLine("Enter the value of the node ?");
                        list.deleteatnode(Int32.Parse(Console.ReadLine()));
                        break;
                    case 12:
                        list.reverse();
                        Console.WriteLine();
                        Console.WriteLine("Reverting list Back to Original State");
                        list.reverse();
                        break;
                    case 13:
                        list.bubbleSort();
                        break;
                }
            }
        }
    }
}
