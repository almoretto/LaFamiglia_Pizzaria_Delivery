using DataContext.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Order
{
    public class OrderBus
    {
        private readonly SvcOrderDb _svcOrderDb;
        public OrderBus() { _svcOrderDb = new SvcOrderDb(); }




        public int FindNextOrderCode() 
        { return _svcOrderDb.FindNextOrderCode(); }
        public int FindNextItemCode() 
        { return _svcOrderDb.FindNextItemCode(); }
        public int FindNexAdditionaltCode() 
        { return _svcOrderDb.FindNexAdditionaltCode(); }
        public int FindNextItemFlavorCode() 
        { return _svcOrderDb.FindNextItemFlavorCode(); }
    }
}
