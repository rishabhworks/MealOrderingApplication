using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrderingApplication.BusinessLogic
{
    public class Manager
    {
        private List<Dish> Dishes { get; set; }
        private List<Dish> SelectedDishes { get; set; }

        public Manager()
        {
            Dishes = new List<Dish>();
            SelectedDishes = new List<Dish>();
        }

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }

        public List<Dish> GetListDishes()
        {
            return Dishes;
        }

        public List<Dish> GetSelectedDishes()
        {
            return SelectedDishes;
        }

        public void AddToOrder(Dish dish)
        {
            SelectedDishes.Add(dish);
        }

        public void RemoveFromOrder(Dish dish)
        {
            SelectedDishes.Remove(dish);
        }
    }
}
