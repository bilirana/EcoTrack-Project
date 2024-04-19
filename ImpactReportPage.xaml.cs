namespace EcoTrack_Project;

public partial class ImpactReportPage : ContentPage
{
    private List<Activity> activities; // This should be populated from the data tier.

    public ImpactReportPage()
    {
        InitializeComponent();
        activities = new List<Activity>(); // Ideally, load this from persistent storage.
    }

    private async void OnGenerateReportClicked(object sender, EventArgs e)
    {
        var activities = await DataStorage.LoadActivitiesAsync();
        var report = new EnvironmentalImpactReport(startDatePicker.Date, endDatePicker.Date, activities);

        totalFootprintLabel.Text = "Total Carbon Footprint: " + report.TotalCarbonFootprint().ToString("N2") + " kg CO2";
        averageFootprintLabel.Text = "Average Footprint: " + report.AverageFootprint().ToString("N2") + " kg CO2";
        highestImpactLabel.Text = "Highest Impact Activity: " + report.HighestImpactActivity();
    }
}