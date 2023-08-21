using Microsoft.AspNetCore.Mvc.RazorPages;
namespace netCore.Pages
{
    public class MultiactionModel : PageModel
    {
        public string Message { get; set; } = "Default GET method";
        public void OnPostRegister() => Message = "Post Register fired!";
        public void OnPostRequestinfo() => Message = "Post Request Info fired!";
        public void OnGetClear() => Message = "Get Clear fired!";
        public void OnGetReset() => Message = "Get Reset fired!";
    }
}