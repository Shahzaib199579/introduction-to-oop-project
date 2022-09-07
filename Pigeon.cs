using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_oop_project
{
    public class Pigeon : Bird
    {
        public Pigeon(string name, string color) : base(name, color)
        {
            
        }

        public void EatPizza()
        {
            Console.WriteLine("Pigeon is eating pizza.");
        }

        public override void Speak()
        {
            Console.WriteLine($"I am a {Color} pigeon and my name is {Name}");
        }

        public void Sleep()
        {
            Console.WriteLine("I am a sleeping pigeon.");
        }
    }
}
