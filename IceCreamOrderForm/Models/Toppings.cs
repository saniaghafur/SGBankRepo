using System.Collections.Generic;

namespace IceCreamOrderForm.Models
{
    internal class Toppings
    {
        public int Id { get; set; }
        public string? ToppingName { get; set; }

        public static List<Toppings> LoadAllToppingNames()
        {
            List<Toppings> toppings = new List<Toppings>();
            toppings.Add(new Toppings { Id = 1, ToppingName = "Caramel" });
            toppings.Add(new Toppings { Id = 2, ToppingName = "Chocolate Chips" });
            toppings.Add(new Toppings { Id = 3, ToppingName = "Chocolate Shavings" });
            toppings.Add(new Toppings { Id = 4, ToppingName = "Fudge" });
            toppings.Add(new Toppings { Id = 5, ToppingName = "GOLDEN OREO® Cookie" });
            toppings.Add(new Toppings { Id = 6, ToppingName = "Heath Bar" });
            toppings.Add(new Toppings { Id = 7, ToppingName = "Peanuts" });

            return toppings;
        }
    }
}
