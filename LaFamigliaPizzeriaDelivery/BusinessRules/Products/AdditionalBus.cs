using DataContext.Products;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.Products
{
    public class AdditionalBus
    {
        private readonly SvcAdditionalDb _svcAdditionalDb;
        public AdditionalBus() { _svcAdditionalDb = new SvcAdditionalDb(); }

        public List<EntityViewProducts> GetEntityViewProducts(Status status)
        { return _svcAdditionalDb.GetEntityViewProducts(status); }

        public List<Additional> GetActiveAdditional()
        { return _svcAdditionalDb.GetActiveAdditional(); }

        public Additional FindById(int id)
        { return _svcAdditionalDb.FindById(id); }

        public int FindNextCode()
        { return _svcAdditionalDb.FindNextCode(); }

        public bool CreateAdditional(Additional newAdditional) 
        { return _svcAdditionalDb.CreateAdditional(newAdditional); }

        public bool UpdateAdditional(Additional additionalToUpdate) 
        { return _svcAdditionalDb.UpdateAdditional(additionalToUpdate); }

        public bool DeleteAdditional(int additionalToDelete)
        { return _svcAdditionalDb.DeleteAdditional(additionalToDelete); }
    }
}
