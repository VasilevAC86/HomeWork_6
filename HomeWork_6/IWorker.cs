using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public interface IWorker
    {        
        void Work(); // Свойство "Работать"
        bool Check(IPart obj, int day); // Свойствво проверки состояния стройки (что построено)
    }
}
