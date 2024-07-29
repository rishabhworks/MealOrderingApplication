using MealOrderingApplication.BusinessLogic;

namespace MealOrderingApplication
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartOrderingClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPage());
        }


    }

}
