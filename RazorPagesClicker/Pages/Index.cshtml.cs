using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesClicker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public int Value { get; set; }

        [BindProperty]
        public int InputValue { get; set; }

        [BindProperty]
        public string Name { get; set; }

        public void OnGet(int value)
        {
            Value = value;
        }

        public void OnGetChange(int value, int current)
        {
            Value = current + value;
        }

        public void OnGetReset(int value)
        {
            Value = value;
        }
    }
}
