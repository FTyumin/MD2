using MD1;

namespace MD2.EditPages;

public partial class EditSubmission : ContentPage
{
    private Submission _submission;
    private DataManager dm;
    public EditSubmission(Submission submission)
	{
		InitializeComponent();
        dm= GlobalVariables.dm;
        _submission = submission;
        StudentPicker.ItemsSource = dm.GetStudents(); // Populate with available students
        AssignmentPicker.ItemsSource =dm.GetAssignments(); // Populate with available assignments
        //LoadSubmissionData();
    }
}