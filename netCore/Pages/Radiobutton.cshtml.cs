using Microsoft.AspNetCore.Mvc.RazorPages;
namespace netCore.Pages
{
    public class RadioButtonModel : PageModel
    {
        public string Language { get; private set; }
        public string[] OfficialLanguages => new[] {
            "Arabic",
            "Chinese",
            "English",
            "French",
            "Russian",
            "Spanish"
        };
        public void OnPost(string language) => Language = language;
        //public void OnPost() => Language = Request.Form["language"];
    }
}