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
        activityDatePicker.Date = DateTime.Now;
        activityDatePicker.MaximumDate = DateTime.Now;
    }

    private void OnLogActivityClicked(object sender, EventArgs e)
    {
        var activityType = activityTypeEntry.Text;
        if (string.IsNullOrWhiteSpace(activityType))
        {
            DisplayAlert("Input Error", "Please enter the type of activity.", "OK");
            return;
        }

        if (!double.TryParse(carbonFootprintEntry.Text, out double carbonFootprint) || carbonFootprint <= 0)
        {
            DisplayAlert("Input Error", "Please enter a valid carbon footprint (positive number).", "OK");
            return;
        }

        var activityDate = activityDatePicker.Date;

        var newActivity = new Activity(activityType, carbonFootprint, activityDate);
        activities.Add(newActivity);

        DisplayAlert("Activity Logged", $"Your {activityType} activity with {carbonFootprint} kg CO2 has been recorded on {activityDate.ToShortDateString()}.", "OK");
        activityTypeEntry.Text = ""; // Clear the input fields
        carbonFootprintEntry.Text = ""; // Clear the input fields
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