using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolutionRep
{
    public class GlobalService : ITransientService,
    IScopedService,
    ISingletonService
    {
        Guid id;
        public GlobalService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
