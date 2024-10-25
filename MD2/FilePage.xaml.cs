using MD1;

namespace MD2;

public partial class FilePage : ContentPage
{
    
    private string filePath;
    public FilePage()
	{
		InitializeComponent();
        
	}
    DataManager dm = GlobalVariables.dm;

    private void SaveBtn_Clicked(object sender, EventArgs e)
    {
        filePath = FileName.Text;
        if (!string.IsNullOrWhiteSpace(filePath))
        {
            // Example of using filePath to save data using DataManager
            dm.save(filePath); // You need to implement this in DataManager
        }
        else
        {
            // Handle the case where no file path is provided
            DisplayAlert("Error", "Please enter a valid file path.", "OK");
        }
    }

    private void LoadBtn_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(filePath))
        {
            // Example of using filePath to load data using DataManager
            /*string loadedData = dm.load(filePath);*/ // You need to implement this in DataManager
            /*SaveBtn.Text = loadedData;*/ // Display loaded data in a button as an example
        }
        else
        {
            // Handle the case where no file path is provided
            DisplayAlert("Error", "Please enter a valid file path.", "OK");
        }

    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
        filePath = ((Entry)sender).Text;

    }
}