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
                Height = 500,
                Stories = 20,
            };


            Building EightEightTwoOne = new Building("the sky"){
                Width = 60,
                Height = 10000,
                Stories = 500,
            };

            Building FourNineZeroTwo = new Building("south of a bean"){
                Width = 1000.3,
                Height = 30,
                Stories = 2,
            };

            Building SixEightOneFour = new Building("Atlantis"){
                Width = 45.23,
                Height = 34,
                Stories = 2,
            };

            List <Building> Buildings = new Buildings() {
                FiveOneTwoEigth,
                EightEightTwoOne,
                FourNineZeroTwo,
                SixEightOneFour,
            };

            foreach(Buildings Building in Buildings) {
                // planner.Building.construct();
                // Console.WriteLine(DateTime);
            };

        }
    }
}
