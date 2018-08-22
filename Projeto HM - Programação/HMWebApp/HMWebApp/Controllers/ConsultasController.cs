using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HMWebApp.DAL;
using HMWebApp.Models;

namespace HMWebApp.Controllers
{
    public class ConsultasController : Controller
    {
        private Banco db = new Banco();

        // GET: Consultas
        public ActionResult Index()
        {
            var consultas = db.consultas.Include(c => c.med).Include(c => c.pac);
            return View(consultas.ToList());
        }

        // GET: Consultas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultas consultas = db.consultas.Find(id);
            if (consultas == null)
            {
                return HttpNotFound();
            }
            return View(consultas);
        }

        // GET: Consultas/Create
        public ActionResult Create()
        {
            ViewBag.MedicosID = new SelectList(db.medicos, "MedicosID", "nome");
            ViewBag.PacientesID = new SelectList(db.pacientes, "ID", "nome");
            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConsultasID,hr_inicio,hr_fim,coments,MedicosID,PacientesID")] Consultas consultas)
        {
            if (ModelState.IsValid)
            {
                db.consultas.Add(consultas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MedicosID = new SelectList(db.medicos, "MedicosID", "nome", consultas.MedicosID);
            ViewBag.PacientesID = new SelectList(db.pacientes, "ID", "nome", consultas.PacientesID);
            return View(consultas);
        }

        // GET: Consultas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultas consultas = db.consultas.Find(id);
            if (consultas == null)
            {
                return HttpNotFound();
            }
            ViewBag.MedicosID = new SelectList(db.medicos, "MedicosID", "nome", consultas.MedicosID);
            ViewBag.PacientesID = new SelectList(db.pacientes, "ID", "nome", consultas.PacientesID);
            return View(consultas);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConsultasID,hr_inicio,hr_fim,coments,MedicosID,PacientesID")] Consultas consultas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MedicosID = new SelectList(db.medicos, "MedicosID", "nome", consultas.MedicosID);
            ViewBag.PacientesID = new SelectList(db.pacientes, "ID", "nome", consultas.PacientesID);
            return View(consultas);
        }

        // GET: Consultas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultas consultas = db.consultas.Find(id);
            if (consultas == null)
            {
                return HttpNotFound();
            }
            return View(consultas);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Consultas consultas = db.consultas.Find(id);
            db.consultas.Remove(consultas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
