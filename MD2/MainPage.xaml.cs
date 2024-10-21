
namespace MD2;

using MD1;
    public partial class MainPage : ContentPage
    {
        int count = 0;
        DataManager dm;


        public MainPage()
        {
            InitializeComponent();
            dm = new DataManager();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
        
            await Navigation.PushAsync(new ViewData());
            
        }
    }


