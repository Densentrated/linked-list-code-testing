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
        
        
        // adds an objective to the tail
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