using Chapter10Exercise1.Models;

namespace Chapter10Exercise1.Reprostry
{
    public class JobsReprostry
    {
        JobportalEx3CH10DbContext db;
        public Job Addjob(Job job)
        {
            db.Availablejobs.Add(job);
            db.SaveChanges();
            return job;
        }
        public Job Removejob(Job job)
        {
            db.Availablejobs.Remove(job);
            db.SaveChanges();
            return job;
        }
        public Job Applyjob(Job job)
        {
            db.Appliedjobs.Add(job);
            db.SaveChanges();
            return job;
        }
    }
}
