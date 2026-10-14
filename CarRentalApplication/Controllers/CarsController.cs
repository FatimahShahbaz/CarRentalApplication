using Microsoft.AspNetCore.Mvc;
using CarRentalApplication.Models;
namespace CarRentalApplication.Controllers
{
    public class CarsController : Controller
    {
        private static List<Car> availableCars =new List<Car> {
        new Car(1,"Alto",3000),
        new Car(2,"Corolla",6000),
        new Car(3,"Civic",8000),
        };
        private static List<Car> bookedCars=new List<Car>();
        public IActionResult Index()
        {
            return View(availableCars);
        }
        [HttpPost]
        public IActionResult Book(int id)
        {
            var car=availableCars.Find(x=> x.Id==id);
            if (car==null)
            {
                return RedirectToAction("Index");
            }
            bookedCars.Add(car);
            availableCars.Remove(car);
            return RedirectToAction("Booked");

        }
        public IActionResult Booked()
        {
            return View(bookedCars);
        }
    }
}
