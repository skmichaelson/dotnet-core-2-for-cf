using Microsoft.AspNetCore.Mvc.RazorPages;
using static SampleWebApp.Helpers;

namespace SampleWebApp.Pages
{
    public class ManifestModel : PageModel
    {
        public string OptionalAttributes { get; set; }
        public string RequiredAttributes { get; set; }
        public string Resources { get; set; }

        public void OnGet()
        {
            OptionalAttributes = GetHtml("OptionalAttributes");
            RequiredAttributes = GetHtml("RequiredAttributes");
            Resources = GetHtml("Resources");
        }

        private string GetHtml(string filename)
        {
            string path = MarkdownPath("Manifest", filename);
            return ParseMarkdownFile(path);
        }
    }
}
