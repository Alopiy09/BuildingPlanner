using System;
using System.Collections.Generic;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue"){
                Width = 30.23,
                Depth = 500,
                Stories = 20,
            };


            Building EightEightTwoOne = new Building("the sky"){
                Width = 60,
                Depth = 10000,
                Stories = 500,
            };

            Building FourNineZeroTwo = new Building("south of a bean"){
                Width = 1000.3,
                Depth = 30,
                Stories = 2,
            };

            Building SixEightOneFour = new Building("Atlantis"){
                Width = 45.23,
                Depth = 34,
                Stories = 2,
            };

            FourNineZeroTwo.construct();
            FiveOneTwoEigth.construct();
            EightEightTwoOne.construct();
            SixEightOneFour.construct();

            FourNineZeroTwo.purchase("Yoshi");
            FiveOneTwoEigth.purchase("mario");
            EightEightTwoOne.purchase("Toad");
            SixEightOneFour.purchase("Sam Fisher");

            FourNineZeroTwo.DisplayBuildings();
            FiveOneTwoEigth.DisplayBuildings();
            EightEightTwoOne.DisplayBuildings();
            SixEightOneFour.DisplayBuildings();
        }
    }
}
