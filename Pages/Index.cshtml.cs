using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace munt_quiz4_dotnet.Pages;

public class IndexModel : PageModel
{
    public string DatabaseMessage { get; set; } = string.Empty;

    public void OnGet()
    {
        DatabaseMessage = "Database access has already been done on April 6, 2026 by Muntsirul";
    }
}