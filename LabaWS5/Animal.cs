using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaWS5
{
    internal class Animal
    {
        internal protected string food;
        internal protected string location;
        public Animal()
        {
            this.food = "undefined";
            this.location = "undefined";
        }
        public Animal(string food, string location)
        {
            this.food = food;
            this.location = location;
        }
        public virtual void makeNoise(bool sleep)
        {
            if (sleep == true) 
                Console.WriteLine("Животное спит");
            else Console.WriteLine($"*звук животного*, доносящийся из локации {this.location}");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"Животное поело {this.food}");
        }
        internal bool Sleep(bool sleep = true)
        {
            if (sleep == true)
                return true;
            else return false;
        }
    }
    internal class Dog : Animal
    {
        internal bool goodboy;
        public Dog() : base()
        {
            this.food = "кость";
            this.location = "будка";
            this.goodboy = false;
        }
        public Dog(string food, string location, bool goodboy) : base(food, location)
        {
            this.goodboy = goodboy;
        }
        public override void makeNoise(bool sleep)
        {
            if (sleep == true & this.goodboy == true)
                Console.WriteLine("Собака спит, хорошая собака)");
            else if (sleep == true & this.goodboy == false)
                Console.WriteLine("Собака спит, плохая собака(");
            else Console.WriteLine($"Лай, доносящийся из локации {this.location}");
        }
        public override void Eat()
        {
            if (this.goodboy == true)
                Console.WriteLine($"Собака поела {this.food}, хорошая собака)");
            else Console.WriteLine($"Собака поела {this.food}, плохая собака(");
        }
    }
    internal class Cat : Animal
    {
        internal int kys;
        public Cat() : base()
        {
            this.food = "рыбу";
            this.location = "диван";
            this.kys = (new Random()).Next(1, 1);
        }
        public Cat(string food, string location, int maxkys) : base(food, location)
        {
            this.kys = (new Random()).Next(1, maxkys);
        }
        public override void makeNoise(bool sleep)
        {
            if (sleep == true)
                Console.WriteLine("Кот спит, куся не будет");
            else Console.WriteLine($"Мяуканье, доносящееся из локации {this.location}");
        }
        public override void Eat()
        {
            Console.WriteLine($"Кот поел {this.food}, количество сделанных вам кусей: {this.kys}");
        }
    }
    internal class Horse : Animal
    {
        internal string fyr;
        public Horse() : base()
        {
            this.food = "яблоко";
            this.location = "стойло";
            this.fyr = "ФЫР";

        }
        public Horse(string food, string location, string fyr) : base(food, location)
        {
            this.fyr = fyr;
        }
        public override void makeNoise(bool sleep)
        {
            if (sleep == true)
                Console.WriteLine($"Лошадь спит, спит стоя и фырчит \"{this.fyr}\"");
            else Console.WriteLine($"Ржание, доносящееся из локации {this.location}. Лошадь профырчала \"{this.fyr}\"");
        }
        public override void Eat()
        {
            Console.WriteLine($"Лошадь поела {this.food} и профырчала \"{this.fyr}\"");
        }
    }
}
