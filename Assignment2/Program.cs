using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Zun Dai
 * Student ID: 300839401
 * Date modified: 2016-06-10
 * Program description: Assigment2, implementing the SuperHero class
 * 
 */

namespace Assignment2
{
    class Program
    {
        //The main method for the driver class Program
        static void Main(string[] args)
        {
            Hero arclight = new Hero();
            arclight.Name = "Arc Light";
            arclight.show();

            Console.WriteLine();

            arclight.fight();

            Console.WriteLine();

            SuperHero newSuperHero = new SuperHero("Arc Light II");
            newSuperHero.showPowers();
        }
    }
}
