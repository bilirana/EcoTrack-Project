namespace EcoTrack_Project
{
    public partial class MainPage : ContentPage
    {
        private readonly List<string> imageNames = new List<string>
    {
        "Resources/Images/a1.jpg",  
        "Resources/Images/a2.jpg",
        "Resources/Images/a3.jpg",
        "Resources/Images/a4.jpg",
    };
        public MainPage()
        {
            InitializeComponent();
            UpdateDashboard();
        }

        private void UpdateDashboard()
        {
            // Assume these methods fetch data from a backend or local storage
            totalCarbonFootprint.Text = "Welcome To EcoTrack";
            recentActivities.Text = "You are appreciated.";
            progressTowardsGoal.Progress = 0.55; 
        }

        private void OnChangePictureClicked(object sender, EventArgs e)
        {
            var random = new Random();
            var randomIndex = random.Next(imageNames.Count);
            displayedImage.Source = ImageSource.FromFile(imageNames[randomIndex]);
        }
    }
}
