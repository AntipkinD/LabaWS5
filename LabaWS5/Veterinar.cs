using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaWS5
{
    internal class Veterinar
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine($"Животное обычно ест {animal.food} и находится в локации {animal.location}");
        }
    }
}
