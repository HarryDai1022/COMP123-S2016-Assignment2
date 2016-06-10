using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Zun Dai
 * Student ID: 300839401
 * Date modified: 2016-06-03
 * Program description: Assigment1, implementing the Hero class
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
        }
    }
}
