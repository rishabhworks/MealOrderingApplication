using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MealOrderingApplication.BusinessLogic
{
    public class Dish
    {
        public string Name {  get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        public string Image {  get; set; }


        public Dish(string image, string name, double price, string description) 
        {
            Name = name;
            Price = price > 0 ? price : throw new ArgumentException("Price must be greater than 0");
            Description = description;
            Image = image;
        }








    }
}
