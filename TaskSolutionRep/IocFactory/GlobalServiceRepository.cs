using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolutionRep.IocFactory
{
    public class GlobalServiceRepository : IGlobalServiceRepository
    {
        private readonly Func<string, IGlobalService> globalService;
        public GlobalServiceRepository(Func<string, IGlobalService> globalService)
        {
            this.globalService = globalService;
        }

        public void AddTransient<TService>()
        {
            throw new NotImplementedException();
        }

        public object GetData()
        {
            return globalService(SourceType.DB.ToString()).GetData();
        }


    }
}
