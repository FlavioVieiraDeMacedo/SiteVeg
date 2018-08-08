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
                                                    p=>p.Nome.Contains(pesquisa)|| 
                                                       p.Local.Contains(pesquisa)||
                                                       p.Tipo.Contains(pesquisa)||
                                                       p.Descricao.Contains(pesquisa)).OrderByDescending(x => x.Nome).Take(15));

        }
    }
}