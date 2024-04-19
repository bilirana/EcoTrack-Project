using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTrack_Project
{
    public class EnvironmentalImpactReport
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Activity> Activities { get; set; }

        public EnvironmentalImpactReport(DateTime start, DateTime end, List<Activity> activities)
        {
            StartDate = start;
            EndDate = end;
            Activities = activities.Where(a => a.Date >= start && a.Date <= end).ToList();
        }

        public double TotalCarbonFootprint()
        {
            return Activities.Sum(a => a.CarbonFootprint);
        }

        public string HighestImpactActivity()
        {
            var highest = Activities.OrderByDescending(a => a.CarbonFootprint).FirstOrDefault();
            return highest != null ? $"{highest.Type} with {highest.CarbonFootprint} kg CO2" : "No activities logged.";
        }

        public double AverageFootprint()
        {
            return Activities.Count > 0 ? TotalCarbonFootprint() / Activities.Count : 0;
        }
    }
}
