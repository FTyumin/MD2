namespace MD2;
using MD2.CreatePages;

public partial class CreateData : ContentPage
{
	public CreateData()
	{
		InitializeComponent();
	}

    async void OnButtonClicked(object sender, EventArgs args)
    {

        await Navigation.PushAsync(new ViewData());

    }

    async void DataFile_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FilePage());
    }

    async void CreateFile_Clicked(object sender, EventArgs e)
    {
        
    }

    async void AssignmentBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAssignment());
    }

    async void StudentBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateStudent());
    }

    async void SubmissionBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateSubmission());
    }
}