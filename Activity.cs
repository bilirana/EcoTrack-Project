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
        public DateTime Date { get; set; } // Date the activity was recorded

        // Constructor to initialize a new activity
        public Activity(string type, double carbonFootprint, DateTime date)
        {
            Type = type;
            CarbonFootprint = carbonFootprint;
            Date = date;
        }

        // Display text for CollectionView or other UI components
        public string DisplayText => $"{Type} - {CarbonFootprint} kg CO2, Date: {Date.ToShortDateString()}";
    }
}