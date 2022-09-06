using System;
using System.Xml;

namespace SpaceClassLibrary
{
    public class Scooter
    {
        public string Name { get; set; } = "Noble Steed";
        public void SelectName()
        {
            Console.WriteLine("Your trusty rusty space scooter needs a name as well. Enter your Scooter's name:");
            string inputname = Console.ReadLine();
            this.Name = inputname;
        }
    }
}
