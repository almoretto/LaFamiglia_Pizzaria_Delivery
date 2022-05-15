using DataContext;
using System;

namespace BusinessRules
{
    public class ProgramGeneralBus
    {
        private readonly ProgramGeneralDB _svcGeneralDb;
       public ProgramGeneralBus() { _svcGeneralDb = new ProgramGeneralDB(); }

        public bool OptimizeAll()
        { return _svcGeneralDb.OptimizeAll(); }
    }
}
