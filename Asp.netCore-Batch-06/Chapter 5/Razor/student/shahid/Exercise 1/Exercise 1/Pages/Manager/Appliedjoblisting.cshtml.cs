using Exercise_1.Models;
using Exercise_1.Reprostry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_1.Pages.Manager
{
    public class AppliedjoblistingModel : PageModel
    {
        Appliedjobreprostry Appliedjobreprostry = new Appliedjobreprostry();

        public List<Jobs> Appliedjobs = new List<Jobs>();
        public void OnGet()
        {
            Appliedjobs = Appliedjobreprostry.GetApplyedjobs();
        }
    }
}
