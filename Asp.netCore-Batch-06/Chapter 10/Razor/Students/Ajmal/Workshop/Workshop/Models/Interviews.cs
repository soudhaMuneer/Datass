using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop.Models
{
    public class Interviews
    {

        public Guid? Id { get; set; }
        public int? JobId { get; set; }
        public string? Company { get; set; }
        public string? Post { get; set; }
        public string? Date { get; set; }
        public string? Location { get; set; }
        public string? Time { get; set; }

        public Interviews(string company, string post, string date, string location, string time)
        {
            //  JobId = jobId;
            Company = company;
            Post = post;
            Date = date;
            Location = location;
            Time = time;
        }
        public Interviews()
        {

        }

        //public Guid Id { get; set; }
        //[ForeignKey(nameof(Company))]
        //public Guid? CompanyId { get; set; }


        //public Guid? JobId { get; set; }

        //public Guid? JobseekerId { get; set; }

        //public DateTime? Date { get; set; }

        //public TimeSpan? Time { get; set; }

        //public string? Location { get; set; }

        //public string? Status { get; set; }

        //public Guid? CreatedBy { get; set; }

        //public DateTime? CreatedDate { get; set; }

        //public virtual User? CreatedByNavigation { get; set; }

        //public virtual Jobs? Job { get; set; }

        //public virtual Companies? Company { get; set; }

        //public virtual User? Jobseeker { get; set; }


    }
}
