﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMember.Interfaces
{
	public interface ICompanyRepository
	{
		bool register(Company company);
		List<Company> ListCompanies();
	}
}
