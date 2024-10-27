
namespace MD2;

using MD1;
    public partial class MainPage : ContentPage
    {
        DataManager dm = GlobalVariables.dm;


    public MainPage()
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
            await Navigation.PushAsync(new CreateData());
        }

        async void CreateAssignment_Clicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new EditDeletePage());
            }
}


