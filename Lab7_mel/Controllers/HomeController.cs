using Lab7_mel.Data;
using Lab7_mel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7_mel.Controllers
{
    public class HomeController : Controller
    {
        private DBcarContext db;
        public HomeController(DBcarContext cars)
        {
            db = cars;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Автомобили";
            var cars = db.Cars.ToList();
            return View(cars);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.gener = new SelectList(db.Generators, "ID", "Name");
            Car band = new Car();
            return View(band);
        }
        [HttpPost]
        public IActionResult Create(Car band)
        {
            //ViewBag.gener = new SelectList(db.Generators, "Id", "Name");
            if (ModelState.IsValid)
            {
                db.Cars.Add(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.gener = new SelectList(db.Generators, "ID", "Name");
            Car car = db.Cars.Find(id);
            return View("Edit", car);
        }
        [HttpPost]
        public ActionResult Edit(Car car)
        {
            db.Cars.Update(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(Car car)
        {
            db.Cars.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Info(Car car)
        {
            var s = db.Generators.Single(x => x.ID == car.GeneratorID);
            ViewBag.generName = s.Name;
            ViewBag.generCapital = s.Capiral;
            ViewBag.generCountry = s.Country;

            return View("Info", car);
        }

        public ActionResult All_Info()
        {
            ViewData["Title"] = "All information";

            ViewBag.count = db.Cars.Count();

            var count = db.Cars.GroupBy(s => s.Year).Select(g => new YearCount{ Year = g.Key, Count = g.Count() });
            ViewBag.yearCar = count.ToList();

            var count1 = db.Cars.GroupBy(s => s.Year).Select(g => new YearCount { Year = g.Key, Count = g.Average(a => a.Price) });
            ViewBag.yearAvg = count1.ToList();

            var count2 = db.Cars.GroupBy(s => s.GeneratorID).Select(g => new YearCount { Year = g.Key, Count = g.Count() });
            ViewBag.car = count2.ToList();

            var gener = db.Generators.ToList();

            var count3 = db.Cars.GroupBy(s => s.GeneratorID).Select(g => new ViewModel { Gener = db.Generators.Single(x => x.ID == g.Key).Name, Count = g.Count() });
            ViewBag.cars = count3.ToList();

            return View("All_Info", gener);
        }
        [HttpPost]
        public ActionResult Info()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
