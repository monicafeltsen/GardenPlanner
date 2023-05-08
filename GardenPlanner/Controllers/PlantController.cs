using GardenPlanner.Models;
using GardenPlanner.Views.Plant;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GardenPlanner.Controllers
{
    [Route("Plant")]
    public class PlantController : Controller
    {

        IDataService dataService;

        public PlantController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(CreatePlant model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            dataService.Add(model);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("")]
        public IActionResult List()
        {
            List<ListPlant> model = dataService.GetAll();
            return View(model);
        }

        [HttpGet("Tips")]

        public IActionResult Tips()
        {
            return View();
        }

        [HttpGet("Month")]
        public IActionResult Month()
        {
            List<ListPlant> plants = dataService.GetByMonth(DateTime.Now.Month);
            return View(new MonthList { Plants = plants, Month = DateTime.Now.Month});
        }
        // EDIT

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            Plant plant = dataService.GetPlant(id);

            return View(plant);
        }

        [HttpPost("Edit/{id}")]
        public IActionResult Edit(Plant plant, int id)
        {
            plant.Id = id;
            dataService.UpdatePlant(plant);
            return RedirectToAction(nameof(List));
        }
        //Delete
        [HttpPost("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            dataService.DeletePlant(id);
            return RedirectToAction(nameof(List));
        }
    }
}
