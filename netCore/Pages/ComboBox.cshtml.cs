using Microsoft.AspNetCore.Mvc.RazorPages;
namespace netCore.Pages
{
    public class ComboBoxModel : PageModel
    {
        public string Country { get; private set; }
        public void OnPost(string country) => Country = country;
        //public void OnPost() => Country = Request.Form["country"];
    }
}