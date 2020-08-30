using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> ListBuildings = new List<Building>();

            Building BobsTacoStand = new Building("321 Jose Way");
            BobsTacoStand.Stories = 3;
            BobsTacoStand.Width = 500;
            BobsTacoStand.Depth = 1000;
            BobsTacoStand.Construct();
            BobsTacoStand.Purchase("Bob Bobberson");
            ListBuildings.Add(BobsTacoStand);

            Building PetrolKing = new Building("545 Main Street");
            PetrolKing.Stories = 2;
            PetrolKing.Width = 700;
            PetrolKing.Depth = 500;
            PetrolKing.Construct();
            PetrolKing.Purchase("Big Dave");
            ListBuildings.Add(PetrolKing);

            Building FixEmUpHospital = new Building("2435 Church Street");
            FixEmUpHospital.Stories = 7;
            FixEmUpHospital.Width = 2000;
            FixEmUpHospital.Depth = 3000;
            FixEmUpHospital.Construct();
            FixEmUpHospital.Purchase("Sister Mary Katherine");
            ListBuildings.Add(FixEmUpHospital);

            BobsTacoStand.DisplayInformation();
            PetrolKing.DisplayInformation();
            FixEmUpHospital.DisplayInformation();

        }

    }
}