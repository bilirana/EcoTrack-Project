namespace EcoTrack_Project;

public partial class ActivityLog : ContentPage
{
	public ActivityLog()
	{
		InitializeComponent();
	}
    private void OnLogActivityClicked(object sender, EventArgs e)
    {
        var activityType = activityTypeEntry.Text;
        var carbonFootprint = double.Parse(carbonFootprintEntry.Text);
        // Log the activity to the system (e.g., save to a file or database)
        DisplayAlert("Activity Logged", $"Your {activityType} activity with {carbonFootprint} kg CO2 has been recorded.", "OK");
    }
}