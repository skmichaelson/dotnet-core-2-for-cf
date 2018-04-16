using Markdig;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;

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
                using (StreamReader sr = new StreamReader("./README.md"))
                {
                    return sr.ReadToEnd();
                }

            }
            catch
            {
                using (StreamReader sr = new StreamReader("./../README.md"))
                {
                    return sr.ReadToEnd();
                }

            }
        }
    }
}
