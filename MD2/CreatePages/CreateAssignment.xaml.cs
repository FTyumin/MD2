namespace MD2.CreatePages;
using MD1;

public partial class CreateAssignment : ContentPage
{
    private DataManager dm;
	public CreateAssignment()
	{
		InitializeComponent();
        dm = GlobalVariables.dm;
        List<Course> result = dm.GetCourses();
        
        CoursePicker.ItemsSource = result ;
    }



    private async void Button_Clicked(object sender, EventArgs e)
    {
        string title = AssignmentNameEntry.Text;
        DateTime date = DueDate.Date;

        // Ensure that CoursePicker has a selected item
        if (CoursePicker.SelectedItem != null && !string.IsNullOrEmpty(title))
        {
            // Cast SelectedItem to Course
            Course course = CoursePicker.SelectedItem as Course;

            if (course != null)
            {
                Console.WriteLine($"Adding assignment: Title = {title}, DueDate = {date}, Course = {course.Name}");

                dm.addAssignment(date, title, course);

                await DisplayAlert("Success", "Assignment added successfully!", "OK");
            }
            else
            {
                await DisplayAlert("Error", "The selected course is invalid.", "OK");
            }
        }
        else
        {
            await DisplayAlert("Error", "Please fill in all fields and select a course.", "OK");
        }
    }




}