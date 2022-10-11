using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public abstract class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }

        public Products(int id, string? name, int? price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public virtual string Examine()
        {
            return $"\n--- {GetType().Name.ToUpper()} ---\nId: {Id} \nName: {Name}\nPrice: {Price}";
        
         }
        public abstract string Use();
    }
}
