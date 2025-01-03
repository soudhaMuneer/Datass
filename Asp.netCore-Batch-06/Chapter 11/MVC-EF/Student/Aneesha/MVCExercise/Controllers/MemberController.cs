using Microsoft.AspNetCore.Mvc;
using MVCExercise.Interface;
using MVCExercise.Models;

namespace MVCExercise.Controllers
{
    public class MemberController : Controller
    {
        public readonly IMemberService _memberService;

        public MemberController(IMemberService MemberService)
        {
            _memberService = MemberService;
        }

        public IActionResult MemberRegistration(CompanyMember Membercompany)
        {
            _memberService.MemberRegistration(Membercompany);
            return View();
        }

        public IActionResult RemoveMember(int id)
        {
            _memberService.RemoveMember(id);
            return View();
        }
        public IActionResult ListMember(CompanyMember Membercompany)
        {
            _memberService.ListMember(Membercompany); 
            return View();
        }


    }
}
