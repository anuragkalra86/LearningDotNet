using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //FoodMenu summerMenu = new FoodMenu();
            //summerMenu.Name = "Summer Menu";
            //MenuItem salmon = new MenuItem();
            //salmon.Title = "Salmon";
            //salmon.Description = "Some fishy salmon";
            //salmon.Price = 24.33;
            //summerMenu.items.Add(salmon);

            //summerMenu.AddMenuItem("Taco", "Mexican food", 1.5);
            //summerMenu.HospitalDirection = "Take right and left and up and 6 feet down";

            //DrinkMenu outsideDrinks = new DrinkMenu();
            //outsideDrinks.Disclaimer = "Do not drink and code";
            //outsideDrinks.AddMenuItem("Vodka", "Mother Russia fav drink", 12.3);
            //outsideDrinks.AddMenuItem("Beer", "We love beer!", 1.2);

            List<Menu> menusFromDatabase = Menu.GetAllMenus();
            Order hungryGuestOrder = new Order();
            foreach(Menu currMenu in menusFromDatabase)
            {
                foreach (MenuItem item in currMenu.items)
                {
                    hungryGuestOrder.items.Add(item);
                }
            }

            Console.WriteLine("The total for hungryGuest is: " + hungryGuestOrder.Total);
        }
    }
}
