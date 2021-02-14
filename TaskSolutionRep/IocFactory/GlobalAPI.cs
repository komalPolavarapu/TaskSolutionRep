using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolutionRep.IocFactory
{
    public class GlobalAPI : IGlobalService
    {
        public object GetData()
        {
            return "Loaded API Data.";
        }
    }
}
