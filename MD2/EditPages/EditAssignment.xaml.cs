using MD1;

namespace MD2.EditPages;
using MD1;
public partial class EditAssignment : ContentPage
{
    private Assignment _assignment;
    private DataManager dm;
    public EditAssignment(Assignment assignment)
    {
        InitializeComponent();
        dm = GlobalVariables.dm;
        List<Course> result = dm.GetCourses();

        CoursePicker.ItemsSource = result;
        _assignment = assignment;
    }
    private async void OnSaveChangesClicked(object sender, EventArgs e)
    {
        // Validate and save the changes
        string description = AssignmentNameEntry.Text;
        DateTime deadline = DueDate.Date;
        Course selectedCourse = CoursePicker.SelectedItem as Course;

        if (string.IsNullOrEmpty(description) || selectedCourse == null)
        {
            await DisplayAlert("Error", "Please enter all fields.", "OK");
            return;
        }

        // Update the assignment properties
        _assignment.Description = description;
        _assignment.Deadline = deadline;
        _assignment.Course = selectedCourse;

        // Save changes (for example, update DataManager's assignment list or database)
        //dm.UpdateAssignment(_assignment);

        await DisplayAlert("Success", "Assignment updated successfully!", "OK");
        await Navigation.PopAsync(); // Return to the previous page
    }

}