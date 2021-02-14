using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolutionRep.IocFactory
{
    public class GlobalCache : IGlobalService
    {
        public object GetData()
        {
            return "Loaded Cache.";
        }
    }
}
