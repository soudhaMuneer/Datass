﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorworkShop.Models
{
	public class Interview
	{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Job))]
        public Guid? JobId { get; set; }
        [ForeignKey(nameof(Jobseeker))]
        public Guid? JobseekerId { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid? CompanyId { get; set; }
        public DateTime? Date { get; set; }

        public TimeSpan? Time { get; set; }

        public string? Location { get; set; }

        public string? Status { get; set; }
        [ForeignKey(nameof(CreatedUser))]
        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual User? CreatedUser { get; set; }

        public virtual Job? Job { get; set; }
        public virtual Company? Company { get; set; }

        public virtual User? Jobseeker { get; set; }
    }
}

