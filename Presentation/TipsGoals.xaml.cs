using System.Collections.ObjectModel;
using EcoTrack_Project.Business;

namespace EcoTrack_Project;

public partial class TipsGoals : ContentPage
{
    private ObservableCollection<Goal> goals = new ObservableCollection<Goal>();

    public TipsGoals()
    {
        InitializeComponent();
        goalsCollectionView.ItemsSource = goals;
    }

    private void OnSetGoalClicked(object sender, EventArgs e)
    {
        var description = goalDescriptionEntry.Text;
        if (double.TryParse(targetReductionEntry.Text, out double targetReduction))
        {
            var newGoal = new Goal(description, targetReduction);
            goals.Add(newGoal);
            goalDescriptionEntry.Text = ""; // Clear the input fields
            targetReductionEntry.Text = "";
        }
        else
        {
            DisplayAlert("Error", "Please enter a valid number for the target reduction.", "OK");
        }
    }

    private void OnRemoveGoalClicked(object sender, EventArgs e)
    {
        var selectedGoal = goalsCollectionView.SelectedItem as Goal;
        if (selectedGoal != null)
        {
            goals.Remove(selectedGoal);
            DisplayAlert("Goal Removed", $"The goal to '{selectedGoal.Description}' has been removed.", "OK");
        }
        else
        {
            DisplayAlert("No Selection", "Please select a goal to remove.", "OK");
        }
    }

}
