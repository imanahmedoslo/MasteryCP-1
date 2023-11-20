using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task2_ConsoleApp
{
    public class Hamster
    {
        private string _name = "ukjent navn";
        public string Name
        {
            get
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
        public List<string> FoodList;
        public HamsterHouse Burrow;
        public HamsterSpecies Species { get; set; }
        public Hamster(string name = "ukjent navn", bool isPet = false, HamsterSpecies species = HamsterSpecies.None)
        {
            Name = name;
            IsPet = isPet;
            Species = species;
            FoodList = new List<string>();
        }
        public Hamster(string name ,HamsterHouse someHouse)
        { Name = name;
          IsPet = false;
          FoodList = new List<string>() { "insects" };
          Burrow = someHouse;
            Species = HamsterSpecies.WinterWhite;

        }
        public string GetHamsterDescription()
        {
            string isPetOrWild = IsPet ? "pet" : "wild";
            string oneOrSeveralTypes = FoodList.Count == 1 ? "type" : "types";
            if (FoodList.Count==0)
            {
                return $"{Name} is a {isPetOrWild} {Species} hamster. {Name} doesn't like any food.";
            }
            else
            {
                return $"{Name} is a {isPetOrWild} {Species} hamster. {Name} likes {FoodList.Count} {oneOrSeveralTypes} of food.";
            }
           
        }
        public string GetBurrowDescription(bool infoCompleted=false)
        {
            /* string variableConvertedLongtitude = Burrow?.Longitude.ToString("F2", CultureInfo.GetCultureInfo("no-NO"))??"";
             string variableConvertedLatitude = Burrow?.Latitude.ToString("F2", CultureInfo.GetCultureInfo("no-NO"))??"";
             if (Burrow != null)
             {
                 return $"{Name} has a burrow at longitude {variableConvertedLongtitude} and latitude {variableConvertedLatitude}.";
             }
             else return $"{Name} doesn't have a burrow.";*/
            if (Burrow == null)
            {
                return $"{Name} doesn't have a burrow.";
            }
            else return Burrow.GetHouseDescription(Name, infoCompleted);
        }
    }
}