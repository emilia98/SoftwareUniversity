using System.Linq;
using System.Web.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    [ValidateInput(false)]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new ShoppingListDbContext())
            {
                var products = db.Products.ToList();
                return View(products);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View("Create", new Product());
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            using (var db = new ShoppingListDbContext())
            {
                if(ModelState.IsValid)
                {
                    db.Products.Add(product);
                    db.SaveChanges();

                    return Redirect("/");
                }

                return View(product);
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

            using (var db = new ShoppingListDbContext())
            {
                var product = db.Products.Find(id);

                if (product == null)
                {
                    return HttpNotFound();
                }

                return View(product);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Product productModel)
        {
            using (var db = new ShoppingListDbContext())
            {
                var productFromDb = db.Products.Find(id);

                if (productFromDb == null)
                {
                    return HttpNotFound();
                }

                if(ModelState.IsValid)
                {
                    productFromDb.Priority = productModel.Priority;
                    productFromDb.Name = productModel.Name;
                    productFromDb.Quantity = productModel.Quantity;
                    productFromDb.Status = productModel.Status;

                    db.SaveChanges();
                    return Redirect("/");
                }

                return View("Edit", productModel);
            }
        }
    }
}