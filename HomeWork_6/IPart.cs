using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public interface IPart
    {
        string Name { get; set; } // Название части дома
        int Days { get; set; } // Кол-во дней на строительство части дома
        void Print(); // Свойство отрисовки построенной части в консоли
        bool Build(int days); // Свойство состояния (true - построено, false - нет)
    }
}
