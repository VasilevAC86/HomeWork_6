using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Roof:IPart // Крыша
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
            for (int i = 0; i < 11; ++i)
            {
                for (int j = 0; j < 12; ++j)
                {
                    if (j == 11 - i)
                    {
                        Console.Write('/');
                        continue;
                    }                   
                    Console.Write(' ');
                }
                for (int j = 11; j < 24; ++j)
                {
                    if ( i == j - 12)
                    {
                        Console.Write('\\');
                        continue;
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
