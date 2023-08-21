using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace netCore.Pages
{
    public class CheckboxModel : PageModel
    {
        public List<string> Languages { get; private set; }
        public string[] OfficialLanguages => new[] {
            "Arabic",
            "Chinese",
            "English",
            "French",
            "Russian",
            "Spanish"
        };
        public void OnPost(List<string> languages) => Languages = languages;
    }
}