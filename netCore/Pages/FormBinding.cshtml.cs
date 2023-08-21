using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace netCore.Pages
{
    [BindProperties]
    public class FormBindingModel : PageModel
    {
        public int Age { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; private set; }
        public void OnPost() => Message = Age < 18 ?
               $"Sorry, {FullName}. You cannot subscribe for our site." :
               $"Hello, {FullName}. Thank you for your subscription. We will send email to the address '{Email}'.";
    }
}