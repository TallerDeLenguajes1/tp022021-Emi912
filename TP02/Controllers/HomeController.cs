using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP02.Models;

namespace TP02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form(string nombre, string apellido, DateTime fnacimiento, string edad, DateTime fechadeIngreso, string rol, string direccion)
        {
            try
            {
                int Edad = Int32.Parse(edad);
                Empleado MiEmpleado = new Empleado(nombre, apellido, Edad, fechadeIngreso, fnacimiento, rol, direccion);
                _logger.LogInformation("Se logeo el empleado " + MiEmpleado.ToString());
                return View(MiEmpleado);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return View("Error");

            }

            
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
