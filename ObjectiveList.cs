using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace objectiveList
{
    public class Objective
    {
        // defines the data part of the linked list (a tuple )
        // this tuple is in the form of (task, time(24hr clock), duration(in min))
        // and defines the pointer (next)
        public  (string, int, int) data;
        public Objective? next;

        // constructor
        public Objective((string, int, int) i)
        {
            data = i;
            next = null;
        }
        
        
        // adds an objective to the tail of the list
        public void AddObjectiveToTail((string, int, int) data)
        {
            if (next == null)
            {
                next = new Objective(data);
            }
            else
            {
                next.AddObjectiveToTail(data);
            }
        }

        public void AddObjectiveByTime((string,int,int) data)
        {
            if (next == null)
            {
                next = new Objective(data);
            }
            else if (data.Item2 < next.data.Item2)
            {
                Objective temp = new Objective (data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddObjectiveByTime(data);
            }
        }
        
        // method that prints the current task
        public void Print()
        {
            Console.Write("[" + data + "]->");
            if (next != null)
            {
                next.Print();
            }
        }
    }

    public class ObjectiveList
    {
        public Objective? head;

        // Constructor for the objective list
        public ObjectiveList()
        {
            head = null;
        }

        // adds an objective to the head of the list
        public void AddObjectiveToHead((string, int, int) data)
        {
            if(head == null)
            {
                head = new Objective(data);
            }
            else
            {
                Objective temp = new Objective(data);
                temp.next = head;
                head = temp;
            }
        }

        // removes the objective at the head of the list
        public void RemoveHead()
        {
            if (head != null)
            {
                head = head.next;
            }
        }
        
        // adds objective to tail of list
        public void AddObjectiveToTail((string, int, int) data)
        {
            if (head == null)
            {
                head = new Objective(data);
            }
            else
            {
                head.AddObjectiveToTail(data);
            }
        }

        // adds objective to the list using the time
        public void AddObjectiveByTime((string, int, int) data)
        {
            if (head == null)
            {
                head = new Objective(data);
            }
            else if (data.Item2 < head.data.Item2)
            {
                AddObjectiveToHead(data);
            }
            else
            {
                head.AddObjectiveByTime(data);
            }
        }

        // Prints the Current Objective List
        public void Print()
        {
            if (head != null)
            {
                head.Print();
            }
        }
    }
}