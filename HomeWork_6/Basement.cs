using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Basement:IPart // Фундамент
    {
        public string Name { get; set; }
        public int Days { get; set; }                
        public bool Build(int days)
        {
            if (days < Days) 
                return false;
            return true;
        }
        public void Print()
        {              
            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 24; ++j)
                    Console.Write('\u2588'.ToString());
                Console.WriteLine();
            }
        }
    }
}
