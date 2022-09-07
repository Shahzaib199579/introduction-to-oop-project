using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_oop_project
{
    public class Penguin : Bird
    {
        public Penguin(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"I am a {Color} penguin and my name is {Name}");
        }

        public override void Fly()
        {
            Console.WriteLine($"My name is {Name}. I am a penguin and I cannot fly.");
        }
    }
}
