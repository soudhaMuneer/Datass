using CompanyMember.Model;
using CompanyMemberRegistration.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMemberRegistration.Repository
{
    public class ApplicationRepository: IApplicationRepository
    {
        private int nextId = 0;

        public static List<Application> applications = new List<Application>();
        public bool Applyjob(Application application)
        {
            application.Id = nextId;
            nextId++;
            if (application != null)
            {
                applications.Add(application);     
                
            }
            return true;
        }
        public List<Application> GetAppliedjob()    
        {
           
            return applications;
        }
        public ApplicationRepository() { }
    }
}
