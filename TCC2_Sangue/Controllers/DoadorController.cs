using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC2_Sangue.Dao;
using TCC2_Sangue.Helpers;
using TCC2_Sangue.Models;

namespace TCC2_Sangue.Controllers
{
    public class DoadorController : Controller
    {
        // GET: Doador
        public ActionResult Index()
        {
            var doadores = new DoadorDao().Buscar();
            return View(doadores);
        }

        public ActionResult Novo()
        {
            ViewBag.Sangues = new SelectList(new SangueDao().Buscar().ToDictionary(x => x.SangueID, x => x.TipoSangue), "Key", "Value");
            return View();
        }


        [HttpPost]
        public ActionResult Novo(Doador ObjDoador)

        {
            try
            {
                new DoadorDao().Gravar(ObjDoador);
                return RedirectToAction("Index").Sucesso("Sucesso ao Gravar o Doador");
            }
            catch (Exception)
            {

                return RedirectToAction("Index").Erro("Erro ao Gravar o Doador");
            }

        }
        public ActionResult Detalhe(int id)
        {
            Doador doador = new DoadorDao().Buscar(id);
            return View(doador);
        }

        public ActionResult Editar(int id)
        {
            var Doador = new DoadorDao().Buscar(id);
            return View(Doador);
        }
        [HttpPost]
        public ActionResult Editar(Doador objDoador)
        {
            try
            {
                new DoadorDao().Alterar(objDoador);

                return RedirectToAction("Index").Sucesso("Sucesso ao editar o Doador");
            }
            catch (Exception)
            {

                return RedirectToAction("Index").Erro("Erro ao editar o Doador");
            }
        }

        public ActionResult Excluir(int id)
        {
            try
            {
                new DoadorDao().Excluir(id);

                return RedirectToAction("Index").Sucesso("Sucesso ao excluir o Doador");
            }
            catch (Exception)
            {

                return RedirectToAction("Index").Erro("Erro ao excluir o Doador");
            }

        }

    }
}