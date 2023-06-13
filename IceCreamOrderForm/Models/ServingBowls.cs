using System.Collections.Generic;

namespace IceCreamOrderForm.Models
{
    internal class ServingBowls
    {
        public int Id { get; set; }
        public string? BowlName { get; set; }

        public static List<ServingBowls> LoadAllServingNames()
        {
            List<ServingBowls> servingBowl = new List<ServingBowls>();
            servingBowl.Add(new ServingBowls { Id = 1, BowlName = "Cone" });
            servingBowl.Add(new ServingBowls { Id = 2, BowlName = "Chocolate Dipped Waffle Bowl" });
            servingBowl.Add(new ServingBowls { Id = 3, BowlName = "Plain Waffle Bowl" });
            servingBowl.Add(new ServingBowls { Id = 4, BowlName = "Sprinkled Waffle Bowl" });
            servingBowl.Add(new ServingBowls { Id = 5, BowlName = "Chocolate Dipped Cone" });

            return servingBowl;
        }

    }
}
