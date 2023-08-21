using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace netCore.Pages
{
    public class ListBoxModel : PageModel
    {
        public (string value, string display)[] Countries => new[] {
            ("US", "United States of America"),
            ("China", "People Republic of China"),
            ("Japan", "Japan"),
            ("Germany", "Federal Republic of Germany"),
        };
        public string[] VisitedCountries { get; private set; }
        public void OnPost()
        {
            var countries = Request.Form["countries"];
            VisitedCountries = countries.ToArray();
        }
    }
}