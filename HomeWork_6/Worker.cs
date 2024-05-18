using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Worker:IWorker
    {        
        public string Name { get; }
        public Worker(string name) { this.Name = name; }
        public void Work()
        {  
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Name + " работает.");
            Console.ForegroundColor= ConsoleColor.White;
        }
        public bool Check(IPart obj, int day)
        {
            if (obj.Build(day))
                return false;
            return true;
        }        
    }
}
