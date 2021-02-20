using DataContext.Products;
using Entities.Enums;
using Entities.Products;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.Products
{
    public class PizzaEdgeBus
    {
        private readonly SvcPizzaEdgeDb _svcPizzaEdgeDb;
        public PizzaEdgeBus() { _svcPizzaEdgeDb = new SvcPizzaEdgeDb(); }

        public List<EntityViewProducts> GetEntityViewProducts(Status status)
        { return _svcPizzaEdgeDb.GetEntityViewProducts(status); }

        public List<PizzaEdgeFilling> GetActiveEdges()
        { return _svcPizzaEdgeDb.GetActiveEdges(); }

        public PizzaEdgeFilling FindById(int id)
        { return _svcPizzaEdgeDb.FindById(id); }

        public bool CreatePizzaEdge(PizzaEdgeFilling newPizzaEdge)
        { return _svcPizzaEdgeDb.CreatePizzaEdge(newPizzaEdge); }

        public bool UpdatePizzaEdge(PizzaEdgeFilling edgeToUpdate)
        { return _svcPizzaEdgeDb.UpdatePizzaEdge(edgeToUpdate); }

        public bool DeletePizzaEdge(int edgeToDelete)
        { return _svcPizzaEdgeDb.DeletePizzaEdge(edgeToDelete); }

        public int FindNextCode()
        { return _svcPizzaEdgeDb.FindNextCode(); }
    }
}
