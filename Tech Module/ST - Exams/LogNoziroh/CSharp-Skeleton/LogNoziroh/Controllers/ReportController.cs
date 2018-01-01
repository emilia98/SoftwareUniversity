namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new LogNozirohDbContext())
            {
                List<Report> reports = db.Reports.ToList();
                return View(reports);
            }
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            using (var db = new LogNozirohDbContext())
            {
                var report = db.Reports.Find(id);

                if(report == null)
                {
                    return HttpNotFound();
                }

                return View(report);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View(new Report());
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Report report)
        {
            using (var db = new LogNozirohDbContext())
            {
                if(ModelState.IsValid)
                {
                    db.Reports.Add(report);
                    db.SaveChanges();

                    return Redirect("/");
                }

                return View(report);
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

            using (var db = new LogNozirohDbContext())
            {
                var report = db.Reports.Find(id);

                if(report == null)
                {
                    return HttpNotFound();
                }

                return View(report);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Report reportModel)
        {
            using (var db = new LogNozirohDbContext())
            {
                var reportFromDb = db.Reports.Find(id);

                if(reportFromDb == null)
                {
                    return HttpNotFound();
                }

                db.Reports.Remove(reportFromDb);
                db.SaveChanges();

                return Redirect("/");
            }
        }
    }
}