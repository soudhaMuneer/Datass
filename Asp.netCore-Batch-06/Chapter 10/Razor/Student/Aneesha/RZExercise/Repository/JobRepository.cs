using RZExercise.DAL;
using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Repository
{
    public class JobRepository : IJobRepo
    {
        private SeekerDBContext _context;
        public Job job = new Job();
        public List<Job> jobs = new List<Job>();


        public JobRepository(SeekerDBContext context)
        {
            _context = context;

            jobs = new List<Job>
            {
                new Job
                {
                    JobId = Guid.NewGuid(),
                    JobTitle = "Software Engineer",
                    Description = "Developing software applications",
                    Location = "Remote",
                    PostedDate = DateTime.UtcNow.Date
                },
                new Job
                {
                    JobId = Guid.NewGuid(),
                    JobTitle = "Data Scientist",
                    Description = "Analyzing big data sets",
                    Location = "New York",
                    PostedDate = DateTime.UtcNow.Date.AddDays(-3)
                },
                new Job
                {
                    JobId = Guid.NewGuid(),
                    JobTitle = "Cloud Engineer",
                    Description = "Deploy Sites in cloud",
                    Location = "London",
                    PostedDate = DateTime.UtcNow.Date.AddDays(-3)
                },
                new Job
                {
                    JobId = Guid.NewGuid(),
                    JobTitle = "AI Specialist",
                    Description = "Build AI Websites",
                    Location = "Korea",
                    PostedDate = DateTime.UtcNow.Date.AddDays(-3)
                },
                new Job
                {
                    JobId = Guid.NewGuid(),
                    JobTitle = "Developer",
                    Description = "Develop Websites",
                    Location = "Abudhabi",
                    PostedDate = DateTime.UtcNow.Date.AddDays(-3)
                }

            };
        }

        public List<Job> GetAll()
        {
            return _context.Jobs.ToList();
        }
        public Job GetById(Guid id)
        {
            return _context.Jobs.FirstOrDefault(e=>e.JobId == id);
        }
    }
}
