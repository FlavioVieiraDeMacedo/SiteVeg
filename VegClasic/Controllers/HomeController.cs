using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VegClasic.Models;

namespace VegClasic.Controllers
{
    public class HomeController : Controller
    {
        private ProdutoContext db = new ProdutoContext();
        
        public ActionResult Index(string pesquisa="")
        {
            return View(db.Produtos.ToList().Where(
                                                    p=>p.Nome.ToLower().Contains(pesquisa.ToLower())|| 
                                                       p.Local.ToLower().Contains(pesquisa.ToLower()) ||
                                                       p.Tipo.ToLower().Contains(pesquisa.ToLower()) ||
                                                       p.Descricao.ToLower().Contains(pesquisa.ToLower())).OrderByDescending(x => x.Nome).Take(15));

        }
    }
}