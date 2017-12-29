using System;
using System.Linq;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
    [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
        [Route("")]
	    public ActionResult Index()
	    {
            using (var db = new TodoListDbContext())
            {
                var tasks = db.Tasks.ToList();
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
            using (var db = new TodoListDbContext())
            {
                if (this.ModelState.IsValid)
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();

                    return Redirect("/");
                }
                return View(task);
            }
               
        }

		[HttpGet]
		[Route("delete/{id}")]
        public ActionResult Delete(int? id)
		{
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var db = new TodoListDbContext())
            {
                var task = db.Tasks.Find(id);

                if (task == null)
                {
                    return HttpNotFound();
                }

                return View(task);
            }          
        }

		[HttpPost]
		[Route("delete/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult DeleteConfirm(int? id)
		{
            using (var db = new TodoListDbContext())
            {
                var taskFromDb = db.Tasks.Find(id);

                if (taskFromDb == null)
                {
                    return HttpNotFound();
                }

                db.Tasks.Remove(taskFromDb);
                db.SaveChanges();

                return Redirect("/");
            }                
        }
	}
}