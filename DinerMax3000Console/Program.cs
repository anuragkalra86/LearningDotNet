using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            MenuItem salmon = new MenuItem();
            salmon.Title = "Salmon";
            salmon.Description = "Some fishy salmon";
            salmon.Price = 24.33;
            summerMenu.items.Add(salmon);

            summerMenu.AddMenuItem("Taco", "Mexican food", 1.5);
            summerMenu.HospitalDirection = "Take right and left and up and 6 feet down";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Vodka", "Mother Russia fav drink", 12.3);
            outsideDrinks.AddMenuItem("Beer", "We love beer!", 1.2);

            Order hungryGuestOrder = new Order();
            for (int i=0; i<summerMenu.items.Count; i++)
            {
                hungryGuestOrder.items.Add(summerMenu.items[i]);
            }

            foreach(MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }
            Console.WriteLine("The total for hungryGuest is: " + hungryGuestOrder.Total);
        }
    }
}
