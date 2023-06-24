using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using objectiveList;

public class Program
{
static void Main(string[] args)
    {    
        ObjectiveList tasksOfToday = new ObjectiveList();
        tasksOfToday.AddObjectiveToTail(("Wake up", 0600, 0));
        tasksOfToday.AddObjectiveToTail(("Eat breakfast", 0700, 30));
        tasksOfToday.AddObjectiveToTail(("Brush Teeth", 0800, 30));
        tasksOfToday.AddObjectiveToHead(("Sleep", 0500, 60*7));
        tasksOfToday.AddObjectiveByTime(("Floss", 0730, 10));
        tasksOfToday.Print();
    }
}
