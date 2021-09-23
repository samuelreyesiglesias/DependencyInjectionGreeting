using DependencyInjectionGreeting.Interfaces;
using DependencyInjectionGreeting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionGreeting.Controllers
{
    public class GreetingController : Controller
    {
        private readonly ILogger<GreetingController> _logger;
        private readonly IGreetingTransient IGTransient;
        private readonly IGreetingScoped IGScoped;
        private readonly IGreetingSingleton IGSingleton;
        private readonly IGreetingSingletonInstance IGSingletonInstance;

        public GreetingController(ILogger<GreetingController> logger,IGreetingTransient TransientInj,IGreetingScoped ScopedInj,IGreetingSingleton SingletonInj,IGreetingSingletonInstance SingletonInstanceInj)
        {
            _logger = logger;
            IGTransient = TransientInj;
            IGScoped = ScopedInj;
            IGSingleton = SingletonInj;
            IGSingletonInstance = SingletonInstanceInj;
        }

        public IActionResult Index()
        {
            ViewBag.Transient = IGTransient ;
            ViewBag.Scoped = IGScoped ;
            ViewBag.Singleton = IGSingleton ;
            ViewBag.SingletonInstance = IGSingletonInstance ;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
