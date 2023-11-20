using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ConsoleApp
{
  
    public class Burrow:HamsterHouse
    {
        public bool IsSelfMade;
        public int NumberOfRooms {  get; set; }
        public Burrow(double longtitude, double lattitude):base(longtitude, lattitude)
        {
            IsSelfMade = true;
            NumberOfRooms = 1;

        }
       
        public Burrow( double longtitude, double lattitude,string name, eCoziness cozinessLvel, int numberOfRooms, bool isSelfMade):base(longtitude, lattitude, name, cozinessLvel)
        {
            IsSelfMade=isSelfMade;
            NumberOfRooms = numberOfRooms;
        }
        public override string GetHouseDescription(string name, bool informationCompleted)
        {
            string selfMadeOrNot = IsSelfMade ? "self made" : "not self made";
            string roomOrRooms = NumberOfRooms == 1 ? "room" : "rooms";
            string result = "";
            if (!informationCompleted)
            {
                result= base.GetHouseDescription(name, informationCompleted); 
            }
            else
            {
               result= $"{base.GetHouseDescription(name,informationCompleted) } the burrow is {selfMadeOrNot} and it has {NumberOfRooms} {roomOrRooms}";
            }
            return result;
        }
    }
}
