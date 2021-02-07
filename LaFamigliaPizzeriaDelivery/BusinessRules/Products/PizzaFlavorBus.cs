using DataContext.Products;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.Products
{
    public class PizzaFlavorBus
    {
        private readonly SvcPizzaFlavorDb _svcPizzaFlavorDb;
        public PizzaFlavorBus() { _svcPizzaFlavorDb = new SvcPizzaFlavorDb(); }

        public List<EntityViewSearch> GetEntityViewSearch(Status status)
        { return _svcPizzaFlavorDb.GetEntityViewSearch(status); }

        public List<PizzaFlavor> GetActiveFlavors()
        { return _svcPizzaFlavorDb.GetActiveFlavors(); }

        public PizzaFlavor FindById(int id)
        { return _svcPizzaFlavorDb.FindById(id); }

        public int FindNextCode()
        { return _svcPizzaFlavorDb.FindNextCode(); }

        public bool CreatePizzaFlavor(PizzaFlavor newPizzaFlavor)
        { return _svcPizzaFlavorDb.CreatePizzaFlavor(newPizzaFlavor); }

        public bool UpdatePizzaFlavor(PizzaFlavor flavorToUpdate)
        { return _svcPizzaFlavorDb.UpdatePizzaFlavor(flavorToUpdate); }

        public bool DeletePizzaFlavor(int flavorToDelete)
        { return _svcPizzaFlavorDb.DeletePizzaFlavor(flavorToDelete); }

    }
}
