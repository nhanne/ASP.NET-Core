using Microsoft.AspNetCore.Mvc.RazorPages;
namespace netCore.Pages
{
    public class UploadModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        public UploadModel(IWebHostEnvironment environment) => _environment = environment;
        public bool Success { get; private set; } = true;
        public void OnPost(IFormFile file)
        {
            try
            {
                var f = Path.Combine(_environment.ContentRootPath, "upload", file.FileName);
                using var fs = new FileStream(f, FileMode.Create);
                file.CopyTo(fs);
                ViewData["file"] = file.FileName;
            }
            catch (Exception)
            {
                Success = false;
            }
        }
    }
}