using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ConsoleApp
{
   public class PlayHouse:HamsterHouse
    {
        public List<string> Toys;
        public PlayHouse(double longtitude, double lattitude) : base(longtitude, lattitude)
        {
            Toys = new List<string>();

        }

        public PlayHouse(double longtitude, double lattitude, string name, eCoziness cozinessLvel, List<string>toys) : base(longtitude, lattitude, name, cozinessLvel)
        {
            Toys = toys;
           
        }
        public override string GetHouseDescription(string name, bool informationCompleted)
        {
            string result = "";
            if (!informationCompleted)
            {
                result = base.GetHouseDescription(name, informationCompleted);
            }
            else
            {
                result = $"{base.GetHouseDescription(name, informationCompleted)} the playHouse has {returnToysAsString()}";
            }
            return result;
        }
        public string returnToysAsString()
        {
            if (Toys==null||Toys.Count==0)
            {
                return "no toys";
            }
            else { string toysAsString= string.Join(", ", Toys);
            return $"the following toys:{toysAsString}";}
        }
    }
}
