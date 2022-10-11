using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public interface IVending
    {
        public string ShowAll();
        public void InsertMoney(int addedMoney);
        public Dictionary<int, int> EndTransaction();
        public Products Purchase(int id);

        //voidClear();
    }
}
