﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskSolutionRep.IocFactory;

namespace TaskSolutionRep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        private IGlobalServiceRepository globalServiceRepository { get; set; }
        public HomeController(IGlobalServiceRepository globalServiceRepository)
        {
            this.globalServiceRepository = globalServiceRepository;
        }

        //public HomeController(ILogger<HomeController> logger,
        //    ITransientService transientService1,
        //    ITransientService transientService2,
        //    IScopedService scopedService1,
        //    IScopedService scopedService2,
        //    ISingletonService singletonService1,
        //    ISingletonService singletonService2)
        //{
        //    _logger = logger;
        //    _transientService1 = transientService1;
        //    _transientService2 = transientService2;
        //    _scopedService1 = scopedService1;
        //    _scopedService2 = scopedService2;
        //    _singletonService1 = singletonService1;
        //    _singletonService2 = singletonService2;
        //}
        //public IActionResult Index()
        //{
        //    ViewBag.transient1 = _transientService1.GetOperationID().ToString();
        //    ViewBag.transient2 = _transientService2.GetOperationID().ToString();
        //    ViewBag.scoped1 = _scopedService1.GetOperationID().ToString();
        //    ViewBag.scoped2 = _scopedService2.GetOperationID().ToString();
        //    ViewBag.singleton1 = _singletonService1.GetOperationID().ToString();
        //    ViewBag.singleton2 = _singletonService2.GetOperationID().ToString();
        //    return View();
        //}
               
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Type of the source ", globalServiceRepository.GetData().ToString() };
        }
        

    }
}
