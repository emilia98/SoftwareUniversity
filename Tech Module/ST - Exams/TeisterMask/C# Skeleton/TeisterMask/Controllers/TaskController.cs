namespace TeisterMask.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using TeisterMask.Models;
    using System.Collections.Generic;

    [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
        [Route("")]
	    public ActionResult Index()
	    {
            using (var db = new TeisterMaskDbContext())
            {
                List<Task> tasks = db.Tasks.ToList();

                return View(tasks);
            }
		}

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
		{
            return View();
		}

		[HttpPost]
		[Route("create")]
        [ValidateAntiForgeryToken]
		public ActionResult Create(Task task)
		{
            using (var db = new TeisterMaskDbContext())
            {
                if(this.ModelState.IsValid)
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();

                    return Redirect("/");
                }
                return View(task);
            }
        }

		[HttpGet]
		[Route("edit/{id}")]
        public ActionResult Edit(int? id)
		{
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var db = new TeisterMaskDbContext())
            {
                var task = db.Tasks.Find(id);

                if(task == null)
                {
                    return HttpNotFound();
                }

                return View("Edit", task);
            }
        }

		[HttpPost]
		[Route("edit/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult EditConfirm(int? id, Task taskModel)
		{
            

            using (var db = new TeisterMaskDbContext())
            {
                var taskFromDb = db.Tasks.Find(id);

                if(taskFromDb == null)
                {
                    return HttpNotFound();
                }

                if(ModelState.IsValid)
                {
                    taskFromDb.Title = taskModel.Title;
                    taskFromDb.Status = taskModel.Status;

                    db.SaveChanges();
                    return Redirect("/");
                }

                return View("Edit", taskModel);
            }   
        }
	}
}