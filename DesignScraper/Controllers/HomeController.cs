using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignScraper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyAccount()
        {
            ViewBag.Message = "Your Account.";
            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "News.";
            return View();
        }

        public ActionResult LogReg()
        {
            ViewBag.Message = "Login / Register";
            return View();
        }

        public ActionResult ValidatedNews()
        {
            ViewBag.Message = "Validated News";
            return View();
        }

        public ActionResult Keywords()
        {
            ViewBag.Message = "Keywords";
            return View();
        }

        public ActionResult GoodNews()
        {
            ViewBag.Message = "GoodNews";
            return View();
        }

        public ActionResult NewsAlreadyPublished()
        {
            ViewBag.Message = "News Already Published";
            return View();
        }

        public ActionResult DocumentGeneration()
        {
            ViewBag.Message = "Document Generation";
            return View();
        }

        public ActionResult Archives()
        {
            ViewBag.Message = "Archives";
            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Settings";
            return View();
        }

        public ActionResult Tampon()
        {
            ViewBag.Message = "Tampon";
            return View();
        }

        public ActionResult Log()
        {
            ViewBag.Message = "Validated News";
            return View();
        }

        public ActionResult Problems()
        {
            ViewBag.Message = "Problems";
            return View();
        }

        public ActionResult VersionHistory()
        {
            ViewBag.Message = "Version History";
            return View();
        }
    }
}