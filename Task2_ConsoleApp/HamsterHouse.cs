using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ConsoleApp
{
    public enum eCoziness {None,Warm,Rocky,Cold,Exposed }
    public  class HamsterHouse
    {
        public double Longitude { get; private set; }
        public double Latitude { get; private set; }
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
        public eCoziness CozinessLvel {  get; private set; }
        
        public HamsterHouse(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
        public HamsterHouse(double longitude, double latitude, string name, eCoziness cozinessLvel) 
        {
            Longitude = longitude;
            Latitude = latitude;
            Name = name;
            CozinessLvel= cozinessLvel;
        }
        public virtual string  GetHouseDescription(string name, bool informationCompleted)
        {
            string variableConvertedLongtitude = Longitude.ToString("F2", CultureInfo.GetCultureInfo("no-NO")) ?? "";
            string variableConvertedLatitude = Latitude.ToString("F2", CultureInfo.GetCultureInfo("no-NO")) ?? "";
            if (!informationCompleted)
            {
                return $"{name} has a {this.GetType().Name.ToLower()} at longitude {variableConvertedLongtitude} and latitude {variableConvertedLatitude}.";
            }
            else
            {
                return $"{name} has a {this.GetType().Name.ToLower()} at longitude {variableConvertedLongtitude} and latitude {variableConvertedLatitude}. the hamster gave its house the name {Name}" +
                    $"and it thinks the house is {CozinessLvel}.";
            }
           
            
           
        }


    }
    
}
