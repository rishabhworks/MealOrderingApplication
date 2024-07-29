using System.Collections.ObjectModel;

namespace MealOrderingApplication.BusinessLogic;

public partial class ViewOrderPage : ContentPage
{

	public Manager Manager { get; set; }

	public ObservableCollection<Dish> SelectedDishes { get; set; }
	public ViewOrderPage(Manager manager)
	{
		InitializeComponent();

        Manager = manager;
        //Initialize the selected dishes collection
        SelectedDishes = new ObservableCollection<Dish>(Manager.GetSelectedDishes());
        //set the binding context of this page
        BindingContext = this;
        //Set the item source for the ListView
        SelectedDishesListView.ItemsSource = SelectedDishes;
    }

    private async void AddMoreItemsButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    // Event handler for the "Checkout" button
    private async void CheckoutButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SummaryPage(Manager));
    }

    // Event handler for item tapped in the ListView
    private void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        var dish = e.Item as Dish;
        if (dish != null)
        {
            // Remove the tapped dish from the order
            Manager.RemoveFromOrder(dish);
            SelectedDishes.Remove(dish); // Refresh the list
        }
    }
}