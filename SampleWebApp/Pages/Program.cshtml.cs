using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleWebApp.Pages
{
    public class ProgramModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "How to configure your Program.cs file";
        }
    }
}
