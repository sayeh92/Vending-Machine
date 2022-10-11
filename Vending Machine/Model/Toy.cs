using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public class Toy : Products
    {
        public int RecommendedAge { get; set; }
        public Toy(int recommendedAge ,int id, string? name, int? price):base(id, name, price)
        {
            RecommendedAge = recommendedAge;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nRecommended age: {RecommendedAge}\n";
        }

        public override string Use()
        {
            return ($"Here's your {Name}, have fun with it!");
        }

        //    public override string Examine()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public override string Use()
        //    {
        //        throw new NotImplementedException();
        //    }
    }
}
