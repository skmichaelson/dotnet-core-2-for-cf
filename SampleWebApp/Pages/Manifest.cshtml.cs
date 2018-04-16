using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleWebApp.Pages
{
    public class ManifestModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "How to configure your manifest.yml file";
        }
    }
}
