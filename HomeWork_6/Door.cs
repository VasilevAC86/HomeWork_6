using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Door:IPart // Дверь
    {
        public string Name { get; set; }
        public int Days { get; set; }
        public bool Build(int days)
        {
            if (days < Days)
                return false;
            return true;
        }
        public void Print() { } // Дверь рисую в стене
    }
}
