namespace MD2;
using MD1;

public partial class ViewData : ContentPage
{

    // ieladējam datus, citādi saraksti būs tukši
    DataManager dm = GlobalVariables.dm;
    public ViewData()
    {
        InitializeComponent();
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

    private void LoadBtn_Clicked(object sender, EventArgs e)
    {
        dm.createTestData();
    }
}