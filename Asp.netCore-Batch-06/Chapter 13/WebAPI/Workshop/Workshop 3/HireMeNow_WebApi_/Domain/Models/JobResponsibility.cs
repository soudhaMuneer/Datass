﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class JobResponsibility
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public Guid JobPost { get; set; }

    public virtual JobPost JobPostNavigation { get; set; } = null!;
}
