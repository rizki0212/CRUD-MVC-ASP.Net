using Indomaret.Context;
using Indomaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indomaret.Controllers
{
    public class IndomaretController : Controller
    {
        //
        // GET: /Indomaret/
        IndoContext db = new IndoContext();
        public ActionResult Index()
        {
            ViewBag.Message = "Selamat Datang Di Aplikasi Indomaret";
            return View(db.indomaret.ToList());
        }

        public ActionResult Tambah ()
        {
            return View();
        }

        public ActionResult Simpan (Indomaretku indo)
        {
            db.indomaret.Add(indo);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Edit (string id)
        {
            Indomaretku indo = db.indomaret.Find(id);
            return View(indo);
        }

        public ActionResult Update (Indomaretku indo)
        {
            db.Entry(indo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete (string id)
        {
            Indomaretku indo = db.indomaret.Find(id);
            db.indomaret.Remove(indo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detail (string id)
        {
            Indomaretku indo = db.indomaret.Find(id);
            return View(indo);
        }
	}
}