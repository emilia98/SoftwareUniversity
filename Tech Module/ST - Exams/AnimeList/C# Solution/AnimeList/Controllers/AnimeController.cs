using System.Linq;
using System.Web.Mvc;
using AnimeList.Models;
using System.Collections.Generic;

namespace AnimeList.Controllers
{
    [ValidateInput(false)]
    public class AnimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new AnimeListDbContext())
            {
                List<Anime> animes = db.Animes.ToList();

                return View(animes);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View(new Anime());
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Anime anime)
        {
            using (var db = new AnimeListDbContext())
            {
                if(ModelState.IsValid)
                {
                    db.Animes.Add(anime);
                    db.SaveChanges();

                    return Redirect("/");
                }

                return View(anime);
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            using (var db = new AnimeListDbContext())
            {
                Anime animeFromDb = db.Animes.Find(id);

                if(animeFromDb == null)
                {
                    return HttpNotFound();
                }

                return View(animeFromDb);
            }               
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Anime animeModel)
        {
            using (var db = new AnimeListDbContext())
            {
                Anime animeFromDb = db.Animes.Find(id);

                if(animeFromDb == null)
                {
                    return HttpNotFound();
                }

                db.Animes.Remove(animeFromDb);
                db.SaveChanges();

                return Redirect("/");
            }
        }
    }
}