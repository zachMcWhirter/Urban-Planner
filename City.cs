using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public DateTime YearEstablished { get; set; }
        public List<Building> ListBuildings { get; set; }
        public void AddBuilding(Building newBuilding)
        {
            ListBuildings.Add(newBuilding);
        }
        public void setMayor(string name)
        {
            Mayor = name;
        }
        public City(string name)
        {
            Name = name;
            YearEstablished = DateTime.Now;
            ListBuildings = new List<Building>();
        }
        public void Greeting()
        {
            Console.WriteLine($"Greetings! Welcome to {Name}!");
            Console.WriteLine($"Established: (in the year of our Lord){YearEstablished}");
            Console.WriteLine($"The Honorable: {Mayor} serving as Mayor");
            Console.WriteLine();
        }
    }
}