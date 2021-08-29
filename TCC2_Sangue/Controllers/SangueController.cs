using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC2_Sangue.Dao;
using TCC2_Sangue.Models;

namespace TCC2_Sangue.Controllers
{
    public class SangueController : Controller
    {
        public ActionResult Index()
        {
            var sangues = new SangueDao().Buscar();
            return View(sangues);
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Sangue objSangue)
        {
            new SangueDao().Gravar(objSangue);
            return RedirectToAction("Index", "Sangue");
        }


        public ActionResult Editar(int id)
        {
            var sangue = new SangueDao().Buscar(id);
            return View(sangue);
        }

        [HttpPost]
        public ActionResult Editar(Sangue objSangue)
        {
            new SangueDao().Alterar(objSangue);
            return RedirectToAction("Index", "Sangue");
        }

        public ActionResult Excluir(int id)
        {
            new SangueDao().Excluir(id);
            return RedirectToAction("Index", "Sangue");
        }
        public ActionResult Detalhe(int id)
        {
            Sangue sangue = new SangueDao().Buscar(id);
            return View(sangue);

        }
    }
}