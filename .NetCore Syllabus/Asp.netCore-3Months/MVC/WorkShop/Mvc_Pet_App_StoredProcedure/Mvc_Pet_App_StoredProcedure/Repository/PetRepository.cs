
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Mvc_Pet_App_StoredProcedure.Models;
using System.Drawing;

namespace Mvc_Pet_App_StoredProcedure.Repository
{
    public class PetRepository
    {
        private readonly PetAppDbContext _context;

        public PetRepository(PetAppDbContext context)
        {
            _context = context;
        }

        public async Task AddPetAsync(Pet pet)
        {
           
                var nameParam = new SqlParameter("@Name", pet.Name);
                var ageParam = new SqlParameter("@Age", pet.Age);
                var locationParam = new SqlParameter("@Location", pet.Location);
                var categoryParam = new SqlParameter("@Category", pet.Category);

                await _context.Database.ExecuteSqlRawAsync("EXEC AddPet @Name, @Age, @Location, @Category", nameParam, ageParam, locationParam, categoryParam);
            
        }

        internal async Task<List<Pet>> GetPetsAsync()
        {
            
            var Pet =    await _context.Pets.FromSqlRaw("EXEC GetPets").ToListAsync();
            return Pet;
        }
        public async Task<IEnumerable<PetCategory>> GetCategoriesAsync()
        {
            return await _context.PetCategories.ToListAsync();
        }
    }
}
