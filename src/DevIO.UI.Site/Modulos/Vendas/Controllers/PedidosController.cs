﻿using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("vendas")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
