using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOrderingApplication.BusinessLogic
{
    public class Bill
    {
        public List<Dish> SelectedItems { get; set; }

        public double ItemsPrice => SelectedItems.Sum(x => x.Price);
        public double HST => ItemsPrice * 0.13;
        public double Tip => ItemsPrice * 0.05;

        public double TotalPrice => ItemsPrice + HST + Tip;

        public Bill(List<Dish> selectedItems)
        {
            SelectedItems = selectedItems;
        }
    }
}
