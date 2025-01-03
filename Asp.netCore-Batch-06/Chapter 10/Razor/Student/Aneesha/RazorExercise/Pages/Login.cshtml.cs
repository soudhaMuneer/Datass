using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.DTOs;
using RazorExercise.Model;
using RazorExercise.Repository;

namespace RazorExercise.Pages
{
    public class LoginModel : PageModel 
    {
        [BindProperty] 
        public LoginDto loginUser {  get; set; }  
        public bool loginFailed { get; set; }
        public static List<User> RegisteredUser => RegisterModel.user;
        public UserRepository UserRepository { get; set; }  = new UserRepository();
        public void OnPost()
        {
            if (ModelState.IsValid)
            {

                var user =UserRepository.Login(loginUser.Email, loginUser.Password);    
                if (user != null) 
                {
                    Console.WriteLine("login successfull");
                    Response.Redirect("/JobList");
                }
                else
                {
                    Console.Write("login failed");
                    loginFailed = true;
                }
            }
        }
    }
}
