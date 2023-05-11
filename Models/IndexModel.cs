

using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace renovering.Models;

public class IndexModel : PageModel
{
    private readonly ILogger _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogInformation($"Log OnGet at {DateTime.Now.ToString()}");
    }
}
