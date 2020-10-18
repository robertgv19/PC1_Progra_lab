using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica_1.Models;


namespace Practica_1.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
          [HttpPost]
        public IActionResult Registrar(Formulario objFormulario){
            if (ModelState.IsValid)
            {
                objFormulario.Respuesta ="= Se registro Correctamente al curso de Alumno ";
            }
            return View("index", objFormulario);
        }

        

    }
}
