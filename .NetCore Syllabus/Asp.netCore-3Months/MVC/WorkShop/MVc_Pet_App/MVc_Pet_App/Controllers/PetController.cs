using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVc_Pet_App.Data;
using MVc_Pet_App.Models;

namespace MVc_Pet_App.Controllers
{
	public class PetController : Controller
	{
		private readonly PetContext _context;

		public PetController(PetContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _context.Pets.ToListAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();

		}
		[HttpPost]
		public async Task<IActionResult> Create(PetDTO petDto)
		{
			if (ModelState.IsValid)
			{
                var pet = new Pet
                {
                    Id = Guid.NewGuid(),
                    Name = petDto.Name,
                    Age = petDto.Age,
                    Gender = petDto.Gender,
                    Discription = petDto.Discription,
                    Location = petDto.Location
                };

                if (petDto.Image != null && petDto.Image.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        petDto.Image.CopyTo(stream);
                        pet.Image = Convert.ToBase64String(stream.ToArray());
                    }
                }
                _context.Pets.Add(pet);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
			return View(petDto);
		}

        // GET: Pet/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            var petDto = new PetDTO
            {
                Name = pet.Name,
                Age = pet.Age,
                Gender = pet.Gender,
                Discription = pet.Discription,
                Location = pet.Location
            };

            return View(petDto);
        }

        // POST: Pet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, PetDTO petDto)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var pet = await _context.Pets.FindAsync(id);
                if (pet == null)
                {
                    return NotFound();
                }

                pet.Name = petDto.Name;
                pet.Age = petDto.Age;
                pet.Gender = petDto.Gender;
                pet.Discription = petDto.Discription;
                pet.Location = petDto.Location;

                if (petDto.Image != null && petDto.Image.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await petDto.Image.CopyToAsync(stream);
                        pet.Image = Convert.ToBase64String(stream.ToArray());
                    }
                }

                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(petDto);
        }

        private bool PetExists(Guid id)
        {
            return _context.Pets.Any(e => e.Id == id);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }
        // POST: Pet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

