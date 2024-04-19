using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTrack_Project
{
    public class Goal
    {
        public int GoalID { get; set; }
        public string Description { get; set; }
        public double TargetReduction { get; set; } // Target reduction in carbon footprint in percentage

        public string TargetReductionText => $"Target Reduction: {TargetReduction}%";

        // Constructor to initialize a new goal with description and target
        public Goal(string description, double targetReduction)
        {
            Description = description;
            TargetReduction = targetReduction;
        }

        // Update the target reduction percentage
        public void UpdateTarget(double newTarget)
        {
            TargetReduction = newTarget;
        }
    }

}
