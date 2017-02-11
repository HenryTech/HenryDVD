using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HenryDVD.DAL;
using HenryDVD.Models;
using PagedList;

namespace HenryDVD.Controllers
{
    public class MoviesController : Controller
    {
        private DVDContext db = new DVDContext();

        // GET: Movies
        public ViewResult Index(string sortOrder, string searchString)
        {            
            ViewBag.TitleSort = string.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.DirectorSort = sortOrder == "Director" ? "director_desc" : "Director";
            ViewBag.WriterSort = sortOrder == "Writer" ? "writer_desc" : "Writer";
            ViewBag.LocSort = sortOrder == "Location" ? "location_desc" : "Location";            

            var movies = from m in db.Movies select m;
            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Title.Contains(searchString) || m.Director.Contains(searchString) || m.Writer.Contains(searchString) || m.Location.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "title_desc":
                    movies=movies.OrderByDescending(m => m.Title);
                    break;
                case "Director":
                    movies = movies.OrderBy(m => m.Director);
                    break;
                case "director_desc":
                    movies = movies.OrderByDescending(m => m.Director);
                    break;
                case "Writer":
                    movies = movies.OrderBy(m => m.Writer);
                    break;
                case "writer_desc":
                    movies = movies.OrderByDescending(m => m.Writer);
                    break;
                case "Location":
                    movies = movies.OrderBy(m => m.Location);
                    break;
                case "location_desc":
                    movies = movies.OrderByDescending(m => m.Location);
                    break;
                default:
                    movies = movies.OrderBy(m => m.Title);
                    break;
            }
            return View(movies.ToList());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Director,Writer,Location")] Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }          

            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movieToUpdate = db.Movies.Find(id);
            if (TryUpdateModel(movieToUpdate, "",
               new string[] { "Title", "Director", "Writer", "Location" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(movieToUpdate);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError=false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Movie movie = db.Movies.Find(id);
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
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
