using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VigenereWeb.Models;
using VigenereWeb.Services;

namespace CesarWeb.Controllers
{
    public class VigenereController : Controller
    {
        private ISeguridadService<string> _seguridadService;

        public VigenereController(ISeguridadService<string> seguridadService)
        {
            _seguridadService = seguridadService;
        }

        
        [HttpPost]
        public IActionResult Encriptar(VigenereViewModel mensajeAEncriptar)
        {
            mensajeAEncriptar.Mensaje = _seguridadService.Encriptar(mensajeAEncriptar.Mensaje, mensajeAEncriptar.Clave);
            return View(mensajeAEncriptar);
        }

        [HttpPost]
        public IActionResult Desencriptar(VigenereViewModel mensajeADesencriptar)
        {
            mensajeADesencriptar.Mensaje = _seguridadService.DesEncriptar(mensajeADesencriptar.Mensaje, mensajeADesencriptar.Clave);
            return View(mensajeADesencriptar);
        }


    }
}
