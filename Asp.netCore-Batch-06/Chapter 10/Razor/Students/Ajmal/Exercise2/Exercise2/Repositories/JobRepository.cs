using Exercise2.Interface;
using Exercise2.Models;
using System.Collections.Generic;
namespace Exercise2.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly HireMeNowDbContext _context;
        public JobRepository(HireMeNowDbContext context)
        {
            _context = context;
        }
        

       
       


        public List<Job> ListJob()
        {
            return _context.Jobs.ToList();
        }
    }
}
