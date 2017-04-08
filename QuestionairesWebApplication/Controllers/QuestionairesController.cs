using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuestionairesWebApplication.Models;

namespace QuestionairesWebApplication.Controllers
{
    public class QuestionairesController : Controller
    {
        private QuestionairesDataEntities db = new QuestionairesDataEntities();

        // GET: Questionaires
        public ActionResult Index()
        {
            return View(db.Questionaire.ToList());
        }

        // GET: Questionaires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questionaire questionaire = db.Questionaire.Find(id);
            if (questionaire == null)
            {
                return HttpNotFound();
            }
            return View(questionaire);
        }

        // GET: Questionaires/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questionaires/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codename,Comments")] Questionaire questionaire)
        {
            if (ModelState.IsValid)
            {
                db.Questionaire.Add(questionaire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questionaire);
        }

        // GET: Questionaires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questionaire questionaire = db.Questionaire.Find(id);
            if (questionaire == null)
            {
                return HttpNotFound();
            }
            return View(questionaire);
        }

        // POST: Questionaires/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codename,Comments")] Questionaire questionaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(questionaire);
        }

        // GET: Questionaires/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questionaire questionaire = db.Questionaire.Find(id);
            if (questionaire == null)
            {
                return HttpNotFound();
            }
            return View(questionaire);
        }

        // POST: Questionaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Questionaire questionaire = db.Questionaire.Find(id);
            db.Questionaire.Remove(questionaire);
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
