using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class House // Дом
    {
        private Basement b_ = new Basement(); // Фундамент дома        
        private Wall[] walls_= new Wall[4]; // Стены дома
        private Door d_ = new Door(); // Дверь дома
        private Window[] windows_ = new Window[4]; // Окна дома
        private Roof r_ = new Roof(); // Крыша дома
        public int Days() { return r_.Days + 1; }
        public House() // Конструктор по умолчанию
        {               
            b_.Name = "фундамент";
            b_.Days = 2; // Два дня на фундамент
            for (int i = 0; i < walls_.Length; i++)
            {
                walls_[i] = new Wall();
                walls_[i].Name = "стена " + (i + 1);
                walls_[i].Days = 3 + b_.Days + i * 3; // По три дня на каждую стену
            }
            d_.Name = "дверь";
            d_.Days = 1 + walls_[3].Days; // Один день на двери
            for (int i = 0; i < windows_.Length; i++)
            {
                windows_[i] = new Window();
                windows_[i].Name = "окно " + (i + 1);
                windows_[i].Days = 1 + d_.Days + i; // По одному дню на каждое окно
            }
            r_.Name = "Крыша";
            r_.Days = 3 + windows_[3].Days; // Три дня на крышу
        }
        public Basement Basement { get { return b_; } } // Доступ к состоянию фундамента
        public Wall[] Walls { get { return walls_ ; } } // Доступ к стенам
        public Door Dor { get { return d_; } } // Доступ к двери
        public Window[] Windows { get { return windows_ ; } } // Доступ к окнам
        public Roof Roof { get { return r_; } } // Доступ к крыше
        public void Print() // Метод вывода рисунка дома в консоль
        {
            r_.Print();
            walls_[0].Print();
            b_.Print();
        }
    }
}
