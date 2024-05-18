using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Team // Бригада
    {
        private TeamLeader header_ = new TeamLeader(); // Бригадир
        private Worker w_basement_ = new Worker("Бетонщик");
        private Worker w_walls_ = new Worker("Строитель стен");
        private Worker w_doors_ = new Worker("Мастер по дверям");
        private Worker w_windows_ = new Worker("Оконщик");
        private Worker w_roof_ = new Worker("Кровельщик");        
        public TeamLeader Header() { return header_; } // Доступ к свойствам бригадира
        public Worker W_basement() { return w_basement_; } // Доступ к свойствам бетонщика
        public Worker W_walls() { return w_walls_; } // Доступ к свойствам строителя стен
        public Worker W_doors() { return w_doors_; } // Доступ к свойствам мастера по дверям
        public Worker W_windows() { return w_windows_; } // Доступ к свойствам оконщика
        public Worker W_roof() { return w_roof_; } // Доступ к свойствам кровельщика
    }    
}
