using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularEdad()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcularEdad(int txtan,string txtn)
        {
            int actual = DateTime.Now.Year;
            int edad = actual - txtan;
            ViewBag.e = edad;
            ViewBag.n = txtn;
            ViewBag.an = txtan;
            return View();

        }
        public ActionResult Calculadora()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculadora(float txtnum1,float  txtnum2)
        {
            float suma = txtnum1 + txtnum2;
            float resta = txtnum1 - txtnum2;
            float multi = txtnum1 * txtnum2;
            float divi = txtnum1 / txtnum2;
            ViewBag.n1 = txtnum1;
            ViewBag.n2 = txtnum2;
            ViewBag.suma = suma;
            ViewBag.resta = resta;
            ViewBag.multi = multi;
            ViewBag.divi = divi;
            return View();
        }

        public ActionResult Conversion()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Conversion(float txtcel, double txtPul)
        {
            float faren= ((9/5)*txtcel)+32;
            double milim=txtPul*25.5;
            ViewBag.cel = txtcel;
            ViewBag.pul = txtPul;
            ViewBag.tem = faren;
            ViewBag.med = milim;
            return View();
        }

        public ActionResult DescuentoCompra()
        {
            return View();
        }
        [HttpPost]

        public ActionResult DescuentoCompra(double tarifa, double total)
        {
            double porcen = ( 100-100*(total/tarifa));
            ViewBag.tar = tarifa;
            ViewBag.tot = total;
            ViewBag.des = porcen;
            return View();
        }

        public ActionResult Estadisticas()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Estadisticas(int suspensos,int aprobados,int notables,int sobresalientes)
        {
            int sus = suspensos;
            int ap = aprobados;
            int not = notables;
            int sob = sobresalientes;
            int total = (suspensos + aprobados);
            ViewBag.sup = sus/total;
            ViewBag.apro = (aprobados / total) * 100;
            ViewBag.not = (notables / total) * 100;
            ViewBag.sob = (sobresalientes / total) * 100;
            return View();

        }
    }

  
}