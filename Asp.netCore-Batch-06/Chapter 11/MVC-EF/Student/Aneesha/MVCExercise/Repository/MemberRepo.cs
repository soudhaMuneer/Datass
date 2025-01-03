using MVCExercise.Interface;
using MVCExercise.Models;

namespace MVCExercise.Repository
{
    public class MemberRepo : IMemberRepo
    {
        CompanyControllerContext _companyControllerContext = new CompanyControllerContext();

        public MemberRepo(CompanyControllerContext companyControllerContext)
        {
            _companyControllerContext = companyControllerContext;
        }

        public CompanyMember MemberRegistration(CompanyMember Membercompany)
        {
            _companyControllerContext.CompanyMembers.Add(Membercompany);    
            _companyControllerContext.SaveChanges();
            return Membercompany;
        }
        public List<CompanyMember> ListMember(CompanyMember Membercompany)
        {
            return _companyControllerContext.CompanyMembers.ToList();
        }
        public CompanyMember GetMemberById(int id)
        {
            return _companyControllerContext.CompanyMembers.Where(e=>e.MemberId==id).FirstOrDefault();   
        }
        public CompanyMember RemoveMember(int id)
        {
           var remove =  _companyControllerContext.CompanyMembers.Where(e=>e.MemberId == id).FirstOrDefault();
            _companyControllerContext.CompanyMembers.Remove(remove);
            _companyControllerContext.SaveChanges() ;
            return remove;
        }
    }
}
