using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTrack_Project
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string Type { get; set; } // e.g., Travel, Heating, Electricity use
        public double CarbonFootprint { get; set; } // in kg of CO2

        public string DisplayText => $"{Type} - {CarbonFootprint} kg CO2";

        public Activity(string type, double carbonFootprint)
        {
            Type = type;
            CarbonFootprint = carbonFootprint;
        }
    }
}
