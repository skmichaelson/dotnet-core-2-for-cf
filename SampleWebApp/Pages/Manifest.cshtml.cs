using Markdig;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace SampleWebApp.Pages
{
    public class ManifestModel : PageModel
    {
        public string OptionalAttributes { get; set; }
        public string RequiredAttributes { get; set; }
        public string Resources { get; set; }

        public void OnGet()
        {
            OptionalAttributes = Markdown.ToHtml(GetOptionalAttributes());
            RequiredAttributes = Markdown.ToHtml(GetRequiredAttributes());
            Resources = Markdown.ToHtml(GetResources());
        }

        private string GetOptionalAttributes()
        {
            using (StreamReader sr = new StreamReader("./Pages/Manifest/OptionalAttributes.md"))
            {
                return sr.ReadToEnd();
            }
        }

        private string GetRequiredAttributes()
        {
            using (StreamReader sr = new StreamReader("./Pages/Manifest/RequiredAttributes.md"))
            {
                return sr.ReadToEnd();
            }
        }

        private string GetResources()
        {
            using (StreamReader sr = new StreamReader("./Pages/Manifest/Resources.md"))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
