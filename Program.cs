using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City McWhirtersville = new City("McWhirtersville");
            McWhirtersville.setMayor("Zachary D. McWhirter");

            Building BobsTacoStand = new Building("321 Jose Way");
            BobsTacoStand.Stories = 3;
            BobsTacoStand.Width = 500;
            BobsTacoStand.Depth = 1000;
            BobsTacoStand.Construct();
            BobsTacoStand.Purchase("Bob Bobberson");
            McWhirtersville.AddBuilding(BobsTacoStand);

            Building PetrolKing = new Building("545 Main Street");
            PetrolKing.Stories = 2;
            PetrolKing.Width = 700;
            PetrolKing.Depth = 500;
            PetrolKing.Construct();
            PetrolKing.Purchase("Big Dave");
            McWhirtersville.AddBuilding(PetrolKing);

            Building FixEmUpHospital = new Building("2435 Church Street");
            FixEmUpHospital.Stories = 7;
            FixEmUpHospital.Width = 2000;
            FixEmUpHospital.Depth = 3000;
            FixEmUpHospital.Construct();
            FixEmUpHospital.Purchase("Sister Mary Katherine Inc");
            McWhirtersville.AddBuilding(FixEmUpHospital);

            McWhirtersville.Greeting();
            foreach (Building building in McWhirtersville.ListBuildings)
            {
                building.DisplayInformation();
                // Console.WriteLine();
            }
        }

    }
}