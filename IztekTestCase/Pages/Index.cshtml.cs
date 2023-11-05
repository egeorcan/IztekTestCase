using IztekTestCase.Data;
using IztekTestCase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IztekTestCase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TestDbContext dbContext;

        public IndexModel(TestDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public CreateInputViewModel CreateInputRequest { get; set; }

        public void OnGet()
        {

        }

        public void OnPost() 
        {
            if (ModelState.IsValid)
            {
                var inputDomainModel = new Input(CreateInputRequest.input);
                dbContext.Add(inputDomainModel);
                dbContext.SaveChanges();

                ViewData["Message"] = "Input submitted";
            }
            
        }
    }
}