using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using PizzeriaContext db = new PizzeriaContext();
            List<Pizza> lista = db.pizze.ToList<Pizza>();
            return View(lista);
        }

        public IActionResult PizzaDetail(int id)
        {
            using PizzeriaContext db = new PizzeriaContext();
            Pizza pizza = db.pizze.FirstOrDefault(x => x.Id == id);
            return View(pizza);
        }

        public IActionResult PizzaForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePizza(Pizza data)
        {
            if (!ModelState.IsValid)
                return View("PizzaForm");
            using PizzeriaContext db = new PizzeriaContext();
            db.pizze.Add(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
