using HieuLinhMidTest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HieuLinhMidTest.Controllers
{
    public class PartController : Controller
    {
        private readonly CarDealerContext _context;


        public PartController(CarDealerContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Parts.Include(s => s.Supplier).ToList();

            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Suppliers = new SelectList(_context.Suppliers.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Part part, IFormFile ProductImage)


        {
            ViewBag.Suppliers = new SelectList(_context.Suppliers.ToList(), "Id","Name");

            _context.Add(part);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
