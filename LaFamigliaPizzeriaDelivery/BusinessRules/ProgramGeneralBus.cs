using DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
