using MD1;
using System.Collections.ObjectModel;

namespace MD2;

public partial class EditDeletePage : ContentPage
{
    private DataManager dm;
    public ObservableCollection<Assignment> Assignments { get; set; }
    public ObservableCollection<Submission> Submissions { get; set; }

    public EditDeletePage()
    {
        InitializeComponent();
        dm = GlobalVariables.dm;

        // Load assignments and submissions
        Assignments = new ObservableCollection<Assignment>(dm.GetAssignments());
        Submissions = new ObservableCollection<Submission>(dm.GetSubmissions());

        AssignmentListView.ItemsSource = Assignments;
        SubmissionListView.ItemsSource = Submissions;
    }

    // Edit Assignment
    private async void OnEditAssignmentClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var assignment = button?.CommandParameter as Assignment;

        if (assignment != null)
        {
            await Navigation.PushAsync(new EditAssignmentPage(assignment));
        }
    }

    // Delete Assignment
    private void OnDeleteAssignmentClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var assignment = button?.CommandParameter as Assignment;

        if (assignment != null)
        {
            Assignments.Remove(assignment);
            dm.DeleteAssignment(assignment);
        }
    }

    // Edit Submission
    private async void OnEditSubmissionClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var submission = button?.CommandParameter as Submission;

        if (submission != null)
        {
            await Navigation.PushAsync(new EditSubmissionPage(submission));
        }
    }

    // Delete Submission
    private void OnDeleteSubmissionClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var submission = button?.CommandParameter as Submission;

        if (submission != null)
        {
            Submissions.Remove(submission);
            dm.DeleteSubmission(submission);
        }
    }
}