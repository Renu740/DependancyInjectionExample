using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependancyInjectionExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyDependency _dependency = new MyDependency();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            string strMessage = _dependency.WriteMessage("IndexModel.OnGet created this message.");
            return Content(strMessage);
        }
    }
}
