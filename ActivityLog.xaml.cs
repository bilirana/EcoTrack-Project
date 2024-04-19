using System.Collections.ObjectModel;
using System.Text;

namespace EcoTrack_Project;

public partial class ActivityLog : ContentPage
{
    private ObservableCollection<Activity> activities = new ObservableCollection<Activity>();

    public ActivityLog()
    {
        InitializeComponent();
        activitiesCollectionView.ItemsSource = activities;
    }

    private void OnLogActivityClicked(object sender, EventArgs e)
    {
        try
        {
            var activityType = activityTypeEntry.Text;
            var carbonFootprint = double.Parse(carbonFootprintEntry.Text); // Validate and parse footprint

            var newActivity = new Activity(activityType, carbonFootprint);
            activities.Add(newActivity);

            DisplayAlert("Activity Logged", $"Your {activityType} activity with {carbonFootprint} kg CO2 has been recorded.", "OK");
            activityTypeEntry.Text = ""; // Clear the input fields
            carbonFootprintEntry.Text = "";
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", "Please enter valid data for the activity.", "OK");
        }
    }

    private void OnRemoveActivityClicked(object sender, EventArgs e)
    {
        var selectedActivity = activitiesCollectionView.SelectedItem as Activity;
        if (selectedActivity != null)
        {
            activities.Remove(selectedActivity);
            DisplayAlert("Activity Removed", $"The activity '{selectedActivity.Type}' has been removed.", "OK");
        }
        else
        {
            DisplayAlert("No Selection", "Please select an activity to remove.", "OK");
        }
    }
}