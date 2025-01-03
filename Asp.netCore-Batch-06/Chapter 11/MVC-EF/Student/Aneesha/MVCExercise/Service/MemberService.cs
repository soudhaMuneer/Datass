using MVCExercise.Interface;
using MVCExercise.Models;

namespace MVCExercise.Service
{
    public class MemberService : IMemberService
    {
        IMemberRepo _memberRepo;

        public MemberService(IMemberRepo memberRepo)
        {
            _memberRepo = memberRepo;
        }

        public CompanyMember MemberRegistration(CompanyMember Membercompany)
        {
            return _memberRepo.MemberRegistration(Membercompany);  
        }
        public List<CompanyMember> ListMember(CompanyMember Membercompany)
        {
            return _memberRepo.ListMember(Membercompany);
        }
        public CompanyMember GetMemberById(int id)
        {
           return _memberRepo.GetMemberById(id);
        }
        public CompanyMember RemoveMember(int id)
        {
            return _memberRepo.RemoveMember(id);
        }
    }
}
