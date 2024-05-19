using Microsoft.AspNetCore.Mvc;
//using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using CRUD.Database;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class ProductController : Controller
    {
        // dependency injections
        private readonly ProductContext _context;
        public ProductController(ProductContext context)
        {
            _context = context;
        }

        public IActionResult Product()
        {

            return View();

        }

        //creating
        [HttpGet]
        public IActionResult CreateProduct()
        {

           ProductModel model = new ProductModel();
            return View(model);
        }

        // Reading
        [HttpGet]
        public IActionResult ProductList()
        {
            var data = _context.Product.ToList();
            return View(data);
        }

        [HttpPost]
        public IActionResult Create(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(model);
                _context.SaveChanges();
                ViewBag.Product = "Created Successfully";
                return RedirectToAction("ProductList");
            }
            return View(model);
        }

        //updating
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = _context.Product.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Update(model);
                _context.SaveChanges();
                ViewBag.Register = "Products updated Successfully";

            }
            return View(model);

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Product.Find(id);
            if (data != null)
            {
                _context.Product.Remove(data);
                _context.SaveChanges();
                ViewBag.Register = "Product deleted Successfully";
                return RedirectToAction("ProductList");
            }
            return NotFound();
        }

    }
}
