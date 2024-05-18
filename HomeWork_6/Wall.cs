using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Wall:IPart // Стена
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
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 24; ++j)
                {
                    if (i == 0)
                    {
                        Console.Write('-');
                        continue;
                    }
                    if (j == 1 || j == 22)
                    {
                        Console.Write('|');
                        continue;
                    }
                    if (i >= 3 && (j == 3 || j == 9))
                    {
                        Console.Write('|');
                        continue;
                    }
                    if (i == 2 && (j > 3 && j < 9))
                    {
                        Console.Write('_');
                        continue;
                    }
                    if (((i > 1 && i < 6) && j == 12) || ((i > 1 && i < 6) && j == 20) || ((i > 1 && i < 6) && j == 16))
                    {
                        Console.Write('|');
                        continue;
                    }
                    if ((i == 1 && (j > 12 && j < 20)) || (i == 5 && (j > 12 && j < 20)))
                    {
                        Console.Write('_');
                        continue;
                    }
                    Console.Write(' ');                   
                }
                Console.WriteLine();
            }
        }
    }
}
