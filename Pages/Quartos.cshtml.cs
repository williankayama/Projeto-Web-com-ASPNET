using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App1.Pages;

public class Quartos : PageModel
{
    private readonly ILogger<Quartos> _logger;

    public Quartos(ILogger<Quartos> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

