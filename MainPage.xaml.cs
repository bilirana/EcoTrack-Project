namespace EcoTrack_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            UpdateDashboard();
        }

        private void UpdateDashboard()
        {
            // Assume these methods fetch data from a backend or local storage
            totalCarbonFootprint.Text = "Total Carbon Footprint: 1500 kg CO2";
            recentActivities.Text = "Recent Activities: Travel, Heating";
            progressTowardsGoal.Progress = 0.75; // 75% towards the goal
        }
    }

}
