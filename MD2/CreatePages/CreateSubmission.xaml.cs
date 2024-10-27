using MD1;

namespace MD2.CreatePages;

public partial class CreateSubmission : ContentPage
{
    private DataManager dm;
    private int scoreInt;
    public CreateSubmission()
	{
		InitializeComponent();
        dm = GlobalVariables.dm;
        List<Course> courses = dm.GetCourses();
        List<Assignment> assignments = dm.GetAssignments();
        List<Student> students = dm.GetStudents();


        CoursePicker.ItemsSource = courses;
        AssignmentPicker.ItemsSource = assignments;
        StudentPicker.ItemsSource = students;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (CoursePicker.SelectedItem != null || AssignmentPicker.SelectedItem != null
            || StudentPicker.SelectedItem != null)
        {

            Course course = CoursePicker.SelectedItem as Course;
            Assignment assignment = AssignmentPicker.SelectedItem as Assignment;
            Student student = StudentPicker.SelectedItem as Student;
            // pārtaisam stringu uz int
            int.TryParse(Score.Text,out scoreInt);
            
            dm.addSubmission(assignment, student, DateTime.Now, scoreInt);
        }



    }
}