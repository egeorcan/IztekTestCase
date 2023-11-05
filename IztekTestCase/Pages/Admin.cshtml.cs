using IztekTestCase.Data;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IztekTestCase.Pages
{
    public class AdminModel : PageModel
    {
        private readonly TestDbContext dbContext;
        public List<Models.Input> Inputs { get; set; }
        public int highestPrime;

        public AdminModel(TestDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet()
        {
            Inputs = dbContext.Inputs.ToList();
            highestPrime = Inputs.Where(x => x.isPrime).Max(x => x.input);
        }
    }
}
