using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class VendingMachineServic : IVending
    {

        
        
        public Dictionary<int, int> EndTransaction()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney(int addedMoney)
        {
            throw new NotImplementedException();
        }

        public Products Purchase(int id)
        {
            throw new NotImplementedException();
        }


        string IVending.ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}
