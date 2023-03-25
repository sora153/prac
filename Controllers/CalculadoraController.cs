using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prac.Models;

namespace Prac.Controllers
{

    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Calculadora objCalculadora)
        {
            double resultado = 0.0;
            
            if(objCalculadora.Operando =="+"){

               TimeSpan diferencia =  objCalculadora.Operador2 - objCalculadora.now ;
               
               int diferenciaEnDias = (int)diferencia.TotalDays;

                 resultado = objCalculadora.Operador3 + ( diferenciaEnDias +( objCalculadora.Operador3 * 0.005 )) ;

            }

            ViewData["Message"] = "El resultado es: "+ resultado;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}