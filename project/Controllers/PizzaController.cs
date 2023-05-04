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
    }
}
