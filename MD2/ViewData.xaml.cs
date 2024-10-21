namespace MD2;
using MD1;

public partial class ViewData : ContentPage
{
DataManager dm = new DataManager();
        // ieladējam datus, citādi saraksti būs tukši
        
    public ViewData()
    {
        InitializeComponent();
        dm.createTestData();
    }

    void OnButtonClicked(object sender, EventArgs args)
    {

        StudentBtn.Text = "Siuu";

    }

    private void TeacherBtn_Clicked(object sender, EventArgs e)
    {
        data.Text = dm.print("teachers");
    }

    private void StudentBtn_Clicked(object sender, EventArgs e)
    {
        data.Text = dm.print("students");
    }

    private void CourseBtn_Clicked(object sender, EventArgs e)
    {
        data.Text = dm.print("courses");
    }

    private void AssignmentBtn_Clicked(object sender, EventArgs e)
    {
        data.Text = dm.print("assignments");
    }

    private void SubmissionBtn_Clicked(object sender, EventArgs e)
    {
        data.Text = dm.print("submissions");
    }
}