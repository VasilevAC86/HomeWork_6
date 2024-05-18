namespace HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();            
            Team team = new Team();
            team.Header().Work();            
            for (int i = 0; i < house.Days(); i++) // Цикл поэтапного строительства дома
            {                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("День " + (i + 1).ToString());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(team.Header().Report(house, i));
                if (team.W_basement().Check(house.Basement, i))
                    team.W_basement().Work();
                else                    
                    if (team.W_walls().Check(house.Walls[0], i) || team.W_walls().Check(house.Walls[1], i)
                        || team.W_walls().Check(house.Walls[2], i) || team.W_walls().Check(house.Walls[3], i))
                        team.W_walls().Work();
                    else
                        if (team.W_doors().Check(house.Dor, i))
                            team.W_doors().Work();
                        else 
                            if (team.W_windows().Check(house.Windows[0], i) || team.W_windows().Check(house.Windows[1], i) 
                                || team.W_windows().Check(house.Windows[2], i) || team.W_windows().Check(house.Windows[3], i))
                                team.W_windows().Work();
                            else 
                                if (team.W_roof().Check(house.Roof, i))
                                    team.W_roof().Work();
            }
            house.Print();
        }
    }
}