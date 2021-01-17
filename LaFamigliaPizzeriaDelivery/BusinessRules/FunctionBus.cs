using DataContext.Modules;

namespace BusinessRules
{
    public class FunctionBus
    {
        private readonly DbFunctions _dbFunctions;

        public FunctionBus() { _dbFunctions = new DbFunctions(); }

        public string OptimizeTables()
        { return _dbFunctions.OptimizeTables(); }
    }
}
