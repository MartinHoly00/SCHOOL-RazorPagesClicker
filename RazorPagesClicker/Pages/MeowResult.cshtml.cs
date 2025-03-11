using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesClicker.Pages
{
    public class MeowResultModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Result { get; set; }

        public void OnGet()
        {
            // The Result property will be automatically bound from the query string
        }
    }
}
