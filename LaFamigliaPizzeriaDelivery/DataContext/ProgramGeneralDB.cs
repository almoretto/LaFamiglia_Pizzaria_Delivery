using DataContext.Modules;

namespace DataContext
{
    public class ProgramGeneralDB
    {
        private readonly DbFunctions _dbFunctions = new DbFunctions();

        public bool OptimizeAll()
        { return _dbFunctions.OptimizeAll(); }
    }
}
