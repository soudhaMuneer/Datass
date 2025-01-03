﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models;

public partial class JobSeekerProfile
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid? ResumeId { get; set; }
    [ForeignKey(nameof(JobSeeker))]
    public Guid JobSeekerId { get; set; }

    public string? ProfileName { get; set; }

    public string? ProfileSummary { get; set; }
    [JsonIgnore]
    public virtual Resume? Resume { get; set; } = null!;

    public virtual JobSeeker JobSeeker { get; set; }
    [JsonIgnore]
    public List<JobSeekerProfileSkill> JobSeekerProfileSkills { get; set; }
    [JsonIgnore]
    public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();
    [JsonIgnore]
    public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
}
