using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class TeamLeader:IWorker // Бригадир
    {
        public string Name { get; }
        public TeamLeader() { this.Name = "Бригадир"; }
        public void Work() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отчёт бригадира по дням строительства:"); 
        }
        public string Report(House house, int day) // Метод составления отчёта бригадира для консоли
        {
            if (!Check(house.Basement, day)) return "Строится " + house.Basement.Name;
            else if (!Check(house.Walls[0], day)) return "Построен " + house.Basement.Name + "\nСтроится " + house.Walls[0].Name;
                else if (!Check(house.Walls[1], day)) return "Построен " + house.Basement.Name + " и " + house.Walls[0].Name + 
                              "\nСтроится " + house.Walls[1].Name;
                    else if (!Check(house.Walls[2], day)) return "Построен фундамент " + house.Basement.Name + " и две стены." +
                                "\nСтроится " + house.Walls[2].Name;
                        else if (!Check(house.Walls[3], day)) return "Построен " + house.Basement.Name + " и три стены.\nСтроится "
                                    + house.Walls[3].Name;
                            else if (!Check(house.Dor, day)) return "Построен " + house.Basement.Name + " и все стены\nСтроится " 
                                        + house.Dor.Name;
                                else if (!Check(house.Windows[0], day)) return "Построен " + house.Basement.Name + ", " + 
                                            house.Dor.Name + " и все стены\nСтроится " + house.Windows[0].Name;
                                    else if (!Check(house.Windows[1], day)) return "Построен " + house.Basement.Name + ", " + 
                                            house.Dor.Name+", все стены и "+house.Windows[0].Name+"\nСтроится "+house.Windows[1].Name;
                                        else if (!Check(house.Windows[2], day)) return "Построен " + house.Basement.Name + ", " +
                                                house.Dor.Name + ", все стены и два окна\nСтроится " + house.Windows[2].Name;
                                            else if (!Check(house.Windows[3], day)) return "Построен " + house.Basement.Name + ", " +
                                                house.Dor.Name + ", все стены и три окна\nСтроится " + house.Windows[3].Name;
                                                else if (!Check(house.Roof, day)) return "Построен " + house.Basement.Name + ", " +
                                                    house.Dor.Name + ", все стены, все окна\nСтроится " + house.Roof.Name;            
            return "Дом построен!";
        }
        public bool Check(IPart obj, int day)
        {
            if (!obj.Build(day))
                return false;            
            return true;
        }
    }
}
