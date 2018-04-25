using Markdig;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static SampleWebApp.Helpers;

namespace SampleWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Body;

        public void OnGet()
        {
            Body = Markdown.ToHtml(Readme());
        }

        private string Readme()
        {
            try
            {
                return ParseMarkdownFile("./README.md");
            }
            catch
            {
                return ParseMarkdownFile("./../README.md");
            }
        }
    }
}
