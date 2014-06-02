using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Potz_TDD.Models;

namespace Potz_TDD.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InserirPotz(Potz potz)
        {

            CupomPotz cupompotz = new CupomPotz(potz.numeroCupom);
            if (potz.numeroCupom != null)
            {
                if (cupompotz.isValido())
                {

                    cupompotz.quantidadePotz();
                    ViewBag.Valor = "Você recebeu " + cupompotz.getPotz() + " potz!";
                }

                else
                    ViewBag.Valor = "Cupom Inválido";

            }
            return View();
        }
        
    }
}
