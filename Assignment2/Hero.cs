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
    class Hero
    {
        //Private instance variables
        private string _name;
        private int _strength;
        private int _speed;
        private int _health;
        private int _rdmNumber;

        //Public property
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        //Constructor method
        public Hero()
        {
            this._initialize();
            generateAbilities();
        }

        private void _initialize()
        {
            this.Name = "unknown name";
        }

        public void generateAbilities()
        {
            Random rdm = new Random();
            this._strength = rdm.Next(1, 101);

            Random speed = new Random();
            this._speed = rdm.Next(1, 101);

            Random health = new Random();
            this._health = rdm.Next(1, 101);
        }

        private bool hitAttempt()
        {
            Random rdmNumber = new Random();
            this._rdmNumber = rdmNumber.Next(1, 101);

            if (this._rdmNumber >= 1 && this._rdmNumber <= 20)
            {
                Console.WriteLine("Arc Light striked!");
                return true;
            }
            else
            {
                Console.WriteLine("Arc Light missed!");
                return false;
            }
        }

        private int hitDamage()
        {
            Random randomNumber = new Random();
            this._rdmNumber = randomNumber.Next(1, 7);
            int damages = this._strength * this._rdmNumber;
            Console.WriteLine("Arc Light caused {0} damage, the random number is {1}.", damages, this._rdmNumber);
            return damages;

        }

        public void fight()
        {
            if (hitAttempt() == true)
            {
                hitDamage();
            }
        }

        //Displaying the hero's scores
        public void show()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Strength: {0}", this._strength);
            Console.WriteLine("Speed   : {0}", this._speed);
            Console.WriteLine("Health  : {0}", this._health);
            Console.WriteLine("*****************");
        }
    }
}
