
namespace MD2;

using MD1;
    public partial class MainPage : ContentPage
    {
        int count = 0;
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
}


