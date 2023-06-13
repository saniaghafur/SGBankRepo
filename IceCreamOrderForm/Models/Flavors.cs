using System.Collections.Generic;

namespace IceCreamOrderForm.Models
{
    internal class Flavors
    {
        public int Id { get; set; }
        public string? FlavorName { get; set; }

        public static List<Flavors> LoadAllFlavorNames()
        {
            List<Flavors> flavors = new List<Flavors>();
            flavors.Add(new Flavors { Id = 1, FlavorName = "Cheesecake" });
            flavors.Add(new Flavors { Id = 2, FlavorName = "Chocolate" });
            flavors.Add(new Flavors { Id = 3, FlavorName = "Cookie Dough" });
            flavors.Add(new Flavors { Id = 4, FlavorName = "Coffee" });
            flavors.Add(new Flavors { Id = 5, FlavorName = "French Vanilla" });
            flavors.Add(new Flavors { Id = 6, FlavorName = "Mango" });
            flavors.Add(new Flavors { Id = 7, FlavorName = "Mint" });
            flavors.Add(new Flavors { Id = 8, FlavorName = "Strawberry" });

            return flavors;
        }
    }
}
