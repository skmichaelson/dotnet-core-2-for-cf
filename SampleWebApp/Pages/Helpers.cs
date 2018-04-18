using Markdig;
using System.IO;

namespace SampleWebApp.Pages
{
    public class Helpers
    {
        private static string PathTemplate = "./Pages/{0}/{1}.md";

        public static string ParseMarkdownFile(string filename)
        {
            string markdown;

            using (StreamReader sr = new StreamReader(filename))
            {
                markdown = sr.ReadToEnd();
            }

            return Markdown.ToHtml(markdown);
        }

        public static string MarkdownPath(string dir, string filename)
        {
            return string.Format(PathTemplate, dir, filename);
        }
    }
}
