using System;
using System.Collections.Generic;


namespace expression_members
{
    // naming the class
    class Program
    {
        // creating a public bug class
        public class Bug
        {
            // prepping for code below. setting blank strings and blank lists to later put things inside
            public string Name { get; } = ""; public string Species { get; } = "";
            public ICollection<string> Predators { get; } = new List<string>();
            public ICollection<string> Prey { get; } = new List<string>();

            // Convert this property to an expression 
            public string FormalName => $"{this.Name} the {this.Species}";

            // Class constructor
            public Bug(string name, string species, List<string> predators, List<string> prey)
            {
                this.Name = name;
                this.Species = species;
                this.Predators = predators;
                this.Prey = prey;
            }

            // Convert this method to an expression member
            public string PreyList => string.Join(",", this.Prey);


            // Convert this method to an expression member
            public string PredatorList => string.Join(",", this.Predators);


            // Convert this to expression method (hint: use a C# ternary)
            // public string Eat(string food) =>
            //     this.Prey.Contains(food) ? $"{this.Name} ate the {food}." : $"{this.Name} is still hungry.";
        }
        static void Main(string[] args)
        {
            Bug emily = new Bug("Emily", "beetle", new List<string>() { "butterflies"}, new List<string>() { "bees" });
            Console.WriteLine($"A {emily.Species} is named {emily.Name}");
            Console.WriteLine($"{emily.Name} is scared of {emily.PredatorList}");
            Console.WriteLine($"{emily.Name} preys on {emily.PreyList}");
        }
    }
}
