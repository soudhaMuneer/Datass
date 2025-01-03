﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.DTOs
{
	public class Joblist
	{
		public Guid Id { get; set; }

		public string JobTitle { get; set; } = null!;

		public string JobSummary { get; set; } = null!;

		public string LocationName { get; set; }
		public string IndustryName { get; set; }
		public string JobCategoryName { get; set; }

		public string PostedByNavigationFirstName { get; set; }

		public DateTime PostedDate { get; set; }

		public bool Saved { get; set; }

	}
}
