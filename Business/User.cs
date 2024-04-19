using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTrack_Project.Business
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Activity> Activities { get; set; } = new List<Activity>();  //creating list for activities
        public List<Goal> Goals { get; set; } = new List<Goal>();   //creating list for goals

        // Add a new activity to the user's list of activities
        public void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }

        // Add a new goal to the user's list of goals
        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
        }
    }
}
