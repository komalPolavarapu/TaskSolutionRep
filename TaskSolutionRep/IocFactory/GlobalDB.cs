using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolutionRep.IocFactory
{
    public class GlobalDB : IGlobalService
    {
        public object GetData()
        {
            return "Loaded DataBase Source......";
        }
    }
}
