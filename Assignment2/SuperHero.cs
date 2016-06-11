using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SuperHero: Hero
    {
        private string[] _superPowers = new string[3];
        private string[] _allPowers ={"Super Speed", "Super Strength", "Body Armor", "Flight", "Fire Generation", "Weather Control"};
        private int _randomElement;
        Random rnd = new Random();

        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        }

        public static int generateRandomElement(Random rnd, int max)
        {
            int randomNumber = rnd.Next(max);
            return randomNumber;
        }

        private void generateRandomPowers()
        {
            string[] power = new string[_allPowers.Length];

            for (int i = 0; i < _allPowers.Length; i++)
            {
                power[i] = _allPowers[i];
            }

            int index = 0;
            while (index < _superPowers.Length)
            {
                this._randomElement = generateRandomElement(rnd, _allPowers.Length);

                if (power[_randomElement] != "Unavailable")
                {
                    this._superPowers[index] = power[this._randomElement];
                    power[this._randomElement] = "Unavailable";
                    index++;
                }
            }
        }

        public void showPowers()
        {
            //Display a list of six powers
            Console.WriteLine("*****************All six powers******************");
            for (int i = 0; i < this._allPowers.Length; i++)
            {
                Console.WriteLine("  {0}'s power is: {1}  ", this._name, this._allPowers[i]);
            }
            Console.WriteLine("*************************************************");

            Console.WriteLine();

            //Display super powers
            Console.WriteLine("************Three random super powers************");
            for (int i = 0; i < _superPowers.Length; i++)
            {
                Console.WriteLine("  {0}'s super power is: {1}  ", this._name, this._superPowers[i]);
            }
            Console.WriteLine("*************************************************");

        }

    }
}
