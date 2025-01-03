using Exercise_1.Models;

namespace Exercise_1.Reprostry
{
    public class Appliedjobreprostry
    {
        private static List<Jobs> Appliedjobs = new List<Jobs>();

        public void PostApplyjob(Jobs job)
        {
            Appliedjobs.Add(job);

        }
        public List<Jobs> GetApplyedjobs()
        {
            return Appliedjobs;
        }

        
    }
}
