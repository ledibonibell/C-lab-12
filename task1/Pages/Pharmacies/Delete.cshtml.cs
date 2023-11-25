using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Pharmacies
{
    public class DeleteModel : PageModel
    {
        private IPharmaciesRepository __db;
        public DeleteModel(IPharmaciesRepository db)
        {
            __db = db;
        }

        [BindProperty]
        public Pharmacy Pharmacy { get; set; }

        public IActionResult OnGet(int id)
        {
            Pharmacy = __db.GetPharmacy(id);
            if (Pharmacy == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Pharmacy = __db.Delete(Pharmacy.PharmacyId);
            if (Pharmacy == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Pharmacies/Pharmacies");
        }
    }
}
