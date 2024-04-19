using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTrack_Project.Business
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string Type { get; set; } // e.g., Type of activity
        public double CarbonFootprint { get; set; } // in kg of CO2
        public DateTime Date { get; set; } // Date of activity

        // Constructor 
        public Activity(string type, double carbonFootprint, DateTime date)
        {
            Type = type;
            CarbonFootprint = carbonFootprint;
            Date = date;
        }

        // Displaying text for CollectionView
        public string DisplayText => $"{Type} - {CarbonFootprint} kg CO2, Date: {Date.ToShortDateString()}";
    }
}