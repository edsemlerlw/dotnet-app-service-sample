using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace dotnetcoresample.Pages;

public class HealthCheckModel : PageModel
{
   public IActionResult Privacy()
   {
        return RedirectPermanent("~/");
   }
    
   public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    
   private readonly ILogger<IndexModel> _logger;

   public HealthCheckModel(ILogger<HealthCheckModel> logger)
    {
        _logger = logger;
    }

   public void OnGet()
    {        
    }
}
