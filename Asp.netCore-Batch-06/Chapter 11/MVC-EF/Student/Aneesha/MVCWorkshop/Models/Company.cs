﻿using System;
using System.Collections.Generic;

namespace MVCWorkshop.Models;

public partial class Company
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string Email { get; set; } = null!;

    public string? Website { get; set; }

    public string? Phone { get; set; }

    public string? Logo { get; set; }

    public string? About { get; set; }

    public string? Vision { get; set; }

    public string? Mission { get; set; }

    public string? Location { get; set; }

    public string? Address { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
