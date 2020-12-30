using DataContext.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules.Products
{
    public class AdditionalBus
    {
        private readonly SvcAdditionalDb _svcAdditionalDb;
        public AdditionalBus() { _svcAdditionalDb = new SvcAdditionalDb(); }

    }
}
