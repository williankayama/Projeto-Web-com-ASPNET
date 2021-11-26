using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App1.Pages;

public class Servicos : PageModel
{
    private readonly ILogger<Servicos> _logger;

    public Servicos(ILogger<Servicos> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

