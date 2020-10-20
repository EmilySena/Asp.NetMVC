using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exemplo.Models;
using Microsoft.AspNetCore.Http;


namespace Exemplo.Controllers
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
            var pessoa = new Pessoa()
            {
                PessoaId=10000000,
                Nome="Fulano",
                Pais="Brasil"
            };
           /* ViewBag.PessoaId = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Pais"] = pessoa.Pais;*/
            return View(pessoa);
        }
        [HttpPost]
        public IActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Pais"] = pessoa.Pais;
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
