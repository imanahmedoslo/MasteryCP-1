using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ConsoleApp
{
    public class Hamster
    {
        private string _name;
        public string Name { get 
            { 
                return _name;
            }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
               else _name = value;
            } 
        }
        public bool IsPet;
        public HamsterSpecies Species { get; set; }
        public Hamster(string name="ukjent navn", bool isPet=false, HamsterSpecies species=HamsterSpecies.None)
        {
            Name = name;
            IsPet = isPet;
            Species = species;
        }
        public string GetHamsterDescription()
        {
            string isPetOrWild = IsPet ? "pet" : "wild";
            return $"{Name} is a {isPetOrWild} {Species} hamster.";
        }
    }
}
