using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        // GET: Article/List
        public ActionResult List()
        {
            using (var db = new BlogDbContext())
            {
                //Get articles from database
                var articles = db.Articles
                                 .Include(a => a.Author)
                                 .ToList();

                return View(articles);
            }
        }

        // GET: Article/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(
                    HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                //Get the article from database
                var article = db.Articles.
                                 Where(a => a.Id == id).
                                 Include(a => a.Author).
                                 First();

                if (article == null)
                {
                    return HttpNotFound();
                }

                return View(article);
            }
        }

        // GET: Article/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(Article article)
        {
            if(ModelState.IsValid)
            {
                //Insert article in database
                using (var db = new BlogDbContext())
                {
                    //Get author id;
                    var authorId = db.Users.
                                      Where(u => u.UserName == this.User.Identity.Name).
                                      First().
                                      Id;

                    //Set articles author
                    article.AuthorId = authorId;

                    //Save article in database
                    db.Articles.Add(article);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

            }
            return View(article);
        }

        // GET: Article/Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(
                    HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                //Get article from database
                var article = db.Articles.
                                 Where(a => a.Id == id).
                                 Include(a => a.Author).
                                 FirstOrDefault();

                //Check if article exists
                if (article == null)
                {
                    return HttpNotFound();
                }

                //Check if the user is the author of the article
                if (!IsUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(
                        HttpStatusCode.Forbidden);
                }

                //Pass article to view
                return View(article);
            }
        }

        // POST: Article/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(
                    HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                //Get article from database
                var article = db.Articles.
                                 Where(a => a.Id == id).
                                 Include(a => a.Author).
                                 First();

                //Check if article exists
                if(article == null)
                {
                    return HttpNotFound();
                }

                //Delete article from database
                db.Articles.Remove(article);
                db.SaveChanges();

                //Redirect to index page
                return RedirectToAction("Index");
            }
        }

        // GET: Article/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(
                    HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                //Get article from the database
                var article = db.Articles.
                                 Where(a => a.Id == id).
                                 FirstOrDefault();
             
                //Check if article exists
                if (article == null)
                {
                    return HttpNotFound();
                }

                //Check if the user is the author of the article
                if (!IsUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(
                        HttpStatusCode.Forbidden);
                }

                //Create the view model
                var model = new ArticleViewModel();
                model.Id = article.Id;
                model.Title = article.Title;
                model.Content = article.Content;

                //Pass the view model to view
                return View(model);
            }
        }

        // POST: Article/Edit
        [HttpPost]
        public ActionResult Edit(ArticleViewModel model)
        {
            //Check if model state is valid
            if(ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    //Get article from database
                    var article = db.Articles.
                                     FirstOrDefault(a => a.Id == model.Id);

                    //Set article properties
                    article.Title = model.Title;
                    article.Content = model.Content;

                    //Save article state in database
                    db.Entry(article).State = EntityState.Modified;
                    db.SaveChanges();

                    //Redirect to the index page
                    return RedirectToAction("Index");
                }
            }

            //If model state is invalid, return the same view
            return View(model);
        }

        private bool IsUserAuthorizedToEdit(Article article)
        {
            bool isAdmin = this.User.IsInRole("Admin");
            bool isAuthor = article.IsAuthor(this.User.Identity.Name);

            return (isAdmin || isAuthor);
        }
    }
}