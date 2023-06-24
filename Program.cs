using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using objectiveList;

namespace CustomLinkedList
{

    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToTail(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToTail(data);
            }
        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node (data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
    }

    public class MyList
    {
        public Node headNode;
        public MyList()
        {
            headNode = null;
        }

        public void AddToTail(int data)
        {
            if (headNode == null)
            {   
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToTail(data);
            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }

        public void AddToHead(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node (data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToHead(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
        
            ObjectiveList tasksOfToday = new ObjectiveList();
            tasksOfToday.AddObjectiveToTail(("Wake up", 0600, 0));
            tasksOfToday.AddObjectiveToTail(("Eat breakfast", 0700, 30));
            tasksOfToday.AddObjectiveToTail(("Brush Teeth", 0800, 30));
            tasksOfToday.Print();


        }
    }
}