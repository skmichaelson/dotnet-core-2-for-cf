using Microsoft.AspNetCore.Mvc.RazorPages;
using static SampleWebApp.Helpers;

namespace SampleWebApp.Pages
{
    public class DotnetPublishModel : PageModel
    {
        public string Flags { get; set; }
        public string Description { get; set; }
        public string Resources { get; set; }

        public void OnGet()
        {
            Description = GetHtml("Description");
            Flags = GetHtml("Flags");
            Resources = GetHtml("Resources");
        }

        private string GetHtml(string filename)
        {
            string path = MarkdownPath("DotnetPublish", filename);
            return ParseMarkdownFile(path);
        }
    }
}
