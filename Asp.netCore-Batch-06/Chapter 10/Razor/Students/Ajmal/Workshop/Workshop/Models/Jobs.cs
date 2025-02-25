﻿using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Workshop.Models
{
    public class Jobs
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public string? Experience { get; set; }

        public string? TypeOfWorkPlace { get; set; }

        public string? Salary { get; set; }

        public string? Responsibilities { get; set; }

        public string? JobType { get; set; }

        public int? VacanciesCount { get; set; }

        public int? AppliedCount { get; set; }

        public string? Status { get; set; }

        public Guid? CompanyId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

        public virtual Companies? Company { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual ICollection<Interviews> Interviews { get; set; } = new List<Interviews>();
    }
}
