using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building BobsTacoStand = new Building("321 Jose Way");
            BobsTacoStand.Stories = 3;
            BobsTacoStand.Width = 500;
            BobsTacoStand.Depth = 1000;
            BobsTacoStand.Construct();
            BobsTacoStand.Purchase("Bob Bobberson");

            foreach (Building building in )
        }

    }
}