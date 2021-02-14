using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolutionRep.IocFactory
{
    public interface IGlobalServiceRepository
    {
        object GetData();

        void AddTransient<TService>();
    }
}
