using System.Collections.Generic;

namespace IceCreamOrderForm.Models
{
    internal class MixIns
    {
        public int Id { get; set; }
        public string? MixinName { get; set; }

        public static List<MixIns> LoadAllMixinNames()
        {
            List<MixIns> mixIns = new List<MixIns>();
            mixIns.Add(new MixIns { Id = 1, MixinName = "Banana" });
            mixIns.Add(new MixIns { Id = 2, MixinName = "Blueberries" });
            mixIns.Add(new MixIns { Id = 3, MixinName = "Brownie" });
            mixIns.Add(new MixIns { Id = 4, MixinName = "Caramel Topping" });
            mixIns.Add(new MixIns { Id = 5, MixinName = "OREO® Cookie" });
            mixIns.Add(new MixIns { Id = 6, MixinName = "Gummy Bears" });
            mixIns.Add(new MixIns { Id = 7, MixinName = "M&M'S®" });
            mixIns.Add(new MixIns { Id = 8, MixinName = "Marshmallows" });
            mixIns.Add(new MixIns { Id = 9, MixinName = "Pretzels" });
            mixIns.Add(new MixIns { Id = 10, MixinName = "REESE'S Peanut Butter Cups" });
            mixIns.Add(new MixIns { Id = 11, MixinName = "Strawberries" });

            return mixIns;
        }
    }
}
