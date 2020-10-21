using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;
using Validacao.Models;


namespace Validacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }
        [HttpPost]
        public ActionResult Index(Pessoa pessoa){
           /* if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ModelState.AddModelError("Nome","O campo nome é obrigatório");
            }

            if (pessoa.Senha != pessoa.ConfirmarSenha)
            {
                ModelState.AddModelError("","As senhas não conferem");
            }*/
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string Login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
            {
                "Annie",
                "Helen",
                "Emily"
            };
            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower() != Login.ToLower()), JsonRequestBehavior.AllowGet);
        }


    }
}