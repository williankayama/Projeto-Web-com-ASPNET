using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App1.Pages;

public class AboutUs : PageModel
{
    private readonly ILogger<AboutUs> _logger;

    public AboutUs(ILogger<AboutUs> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

