using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesClicker.Pages
{
    public class MeowModel : PageModel
    {
        [BindProperty]
        public string InputValue { get; set; }

        public void OnGet() { }

        public IActionResult OnPostShow()
        {
            if (string.IsNullOrEmpty(InputValue))
            {
                return Page();
            }
            return Page();
        }

        public IActionResult OnPostAnotherAction()
        {
            if (string.IsNullOrEmpty(InputValue))
            {
                return Page();
            }
            return RedirectToPage("MeowResult", new { result = InputValue });
        }
    }
}
