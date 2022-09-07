using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_oop_project
{
    public abstract class Bird: IDance
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"I am a {Color} bird and my name is {Name}");
        }

        public virtual void Fly()
        {
            Console.WriteLine($"My name is {Name} and I fly.");
        }

        public void Spin()
        {
            Console.WriteLine($"{Name} spins.");
        }

        public void DoTheCatterpillar()
        {
            Console.WriteLine($"{Name} does the catterpillar.");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jumps.");
        }
    }
}
