﻿using MVCExercise.Models;

namespace MVCExercise.Interface
{
    public interface IMemberRepo
    {
        CompanyMember MemberRegistration(CompanyMember Membercompany);
        List<CompanyMember> ListMember(CompanyMember Membercompany);
        CompanyMember GetMemberById(int id);
        CompanyMember RemoveMember(int id);
    }
}