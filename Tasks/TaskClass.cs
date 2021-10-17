using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class TaskClass
    {
        public List<Task<string>> GetStringListWAITALL()
        {
            List<Task<string>> list = new List<Task<string>>();
            for (int i = 0; i < 10; i++)
            {
                Task<string> t = Task.Run(() => GenerateRandomString());
                list.Add(t);
            }
            Task.WaitAll(list.ToArray());
            var list1 = Task.WhenAll(list);
            return list;
        }

        public List<Task<string>> GetStringList()
        {
            List<Task<string>> list = new List<Task<string>>();
            for (int i = 0; i < 10; i++)
            {
                var t = Task.Run(() => GenerateRandomString());
                list.Add(t);
            }
            return list;
        }

        public string GenerateRandomString()
        {
            Random random = new Random();
            int length = 16;
            var rString = "";
            for (var i = 0; i < length; i++)
            {
                rString += ((char)(random.Next(1, 26) + 64)).ToString().ToLower();
            }
            Thread.Sleep(1000);
            return rString;
        }
    }
}
