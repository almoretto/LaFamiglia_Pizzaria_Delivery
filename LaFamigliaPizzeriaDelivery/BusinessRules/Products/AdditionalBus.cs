using DataContext.Products;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
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

        public List<EntityViewSearch> GetEntityViewSearch(Status status)
        { return _svcAdditionalDb.GetEntityViewSearch(status); }

        public List<Additional> GetActiveAdditional()
        { return _svcAdditionalDb.GetActiveAdditional(); }

        public Additional FindById(int id)
        { return _svcAdditionalDb.FindById(id); }

        public int FindNextCode()
        { return _svcAdditionalDb.FindNextCode(); }

        public bool CreateAdditional(Additional newAdditional)
        { return _svcAdditionalDb.CreateAdditional(newAdditional); }
    }
}
