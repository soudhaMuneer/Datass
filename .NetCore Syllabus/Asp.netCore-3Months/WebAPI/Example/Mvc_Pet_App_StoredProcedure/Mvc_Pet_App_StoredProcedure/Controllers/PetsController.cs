using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc_Pet_App_StoredProcedure.Models;
using Mvc_Pet_App_StoredProcedure.Repository;

namespace Mvc_Pet_App_StoredProcedure.Controllers
{
    public class PetsController : Controller
    {
        private readonly PetRepository _repository;

        public PetsController(PetRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var pets = await _repository.GetPetsAsync();
            return View(pets);
        }
        public async Task<IActionResult> CreateAsync()
        {
            ViewBag.Categories = new SelectList(await _repository.GetCategoriesAsync(), "Id", "Name");
            return View();
          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddPetAsync(pet);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = new SelectList(await _repository.GetCategoriesAsync(), "Id", "Name", pet.Category);
            return View(pet);
        }
    }
}
