using CompanyMember.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMemberRegistration.Interfaces
{
    public interface IApplicationRepository
    {
        bool Applyjob(Application application);
        List<Application> GetAppliedjob();
    }
}
