using DataContext.Products;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.Products
{
    public class PizzaSizeBus
    {
        private readonly SvcPizzaSizeDb _svcPizzaSizeDb;
        public PizzaSizeBus() { _svcPizzaSizeDb = new SvcPizzaSizeDb(); }

        public List<EntityViewSearch> GetEntityViewSearch(Status status)
        { return _svcPizzaSizeDb.GetEntityViewSearch(status); }

        public List<PizzaSize> GetActiveSizes()
        { return _svcPizzaSizeDb.GetActiveSizes(); }

        public PizzaSize FindById(int id)
        { return _svcPizzaSizeDb.FindById(id); }

        public int FindNextCode()
        { return _svcPizzaSizeDb.FindNextCode(); }

        public bool CreatePizzaSize(PizzaSize newPizzaSize)
        { return _svcPizzaSizeDb.CreatePizzaSize(newPizzaSize); }

        public bool UpdatePizzaSize(PizzaSize SizeToUpdate)
        { return _svcPizzaSizeDb.UpdatePizzaSize(SizeToUpdate); }

        public bool DeletePizzaSize(int SizeToDelete)
        { return _svcPizzaSizeDb.DeletePizzaSize(SizeToDelete); }

    }
}
