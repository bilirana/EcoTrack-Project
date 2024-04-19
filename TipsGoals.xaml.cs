namespace EcoTrack_Project;

public partial class TipsGoals : ContentPage
{
	public TipsGoals()
	{
		InitializeComponent();
	}
    private void OnSetGoalClicked(object sender, EventArgs e)
    {
        var goalDescription = goalDescriptionEntry.Text;
        // Set the goal in the system (e.g., save to a file or database)
        DisplayAlert("Goal Set", $"Your goal to '{goalDescription}' has been set.", "OK");
    }
}
