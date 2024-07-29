using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MealOrderingApplication.BusinessLogic;

public partial class OrderPage : ContentPage
{

	public Manager Manager { get; set; }

	public ObservableCollection<Dish> Dishes { get; set; }

	public ICommand AddToOrderCommand { get; set; }
	public OrderPage()
	{
		InitializeComponent();

        Manager = new Manager();
        AddToOrderCommand = new Command<Dish>(AddToOrder);

        // Example data, replace with real data source
        Dishes = new ObservableCollection<Dish>
            {
                new Dish("burger.jpg", "Burger", 15.50, "Delicious"),
                new Dish("grilled.jpg", "Grilled Meat", 20.00, "Tasty"),
                new Dish("salad.jpg", "Salad", 10.50, "Healthy"),
                new Dish("pizza.png", "Pizza", 12.00, "Italian"),
                new Dish("noodle.jpg", "Noodle", 12.00, "Thai"),
                new Dish("salad.jpg", "Salad And Egg", 15.00, "Healthy"),
                new Dish("pizza.png", "Veggie Pizza", 10.00, "Italian")
            };
        // Set the binding context to this page
        BindingContext = this;

    }
    private async void AddToOrder(Dish dish)
    {
        Manager.AddToOrder(dish);
        await DisplayAlert("Dish Added", $"{dish.Name} has been added to your order.", "OK");
    }

    // Event handler for showing the order page
    private async void OnShowOrderClicked(object sender, EventArgs e)
    {
        if (Manager.GetSelectedDishes().Any())
        {
            await Navigation.PushAsync(new ViewOrderPage(Manager));
        }
        else
        {
            await DisplayAlert("No Order", "Please add dishes to your order before proceeding.", "OK");
        }
    }













}