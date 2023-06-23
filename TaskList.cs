using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace taskList
{
    public class Task
    {
        // defines the data part of the linked list (a tuple )
        // and defines the pointer (next)
        public  string data;
        public Task next;

        // constructor
        public Task(string i)
        {
            data = i;
            next = null;
        }

        // method that prints the current task
        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }
    }
}