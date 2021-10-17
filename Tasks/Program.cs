using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskClass tc = new TaskClass();
            Console.WriteLine("without waiting all the tasks to finish");
            foreach(var str in tc.GetStringList())
            {
                Console.WriteLine(str.Result);
            }

            Console.WriteLine("\nwaiting all the tasks to finish");
            foreach (var str in tc.GetStringListWAITALL())
            {
                Console.WriteLine(str.Result);
            }
        }
    }
}
