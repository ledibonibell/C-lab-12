using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Pharmacies
{
    public class EditModel : PageModel
    {
        private readonly IPharmaciesRepository pharmaciesRepository;

        public EditModel(IPharmaciesRepository pharmaciesRepository)
        {
            this.pharmaciesRepository = pharmaciesRepository;
        }

        [BindProperty]
        public Pharmacy Pharmacy { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Pharmacy = pharmaciesRepository.GetPharmacy(id.Value);
            }
            else
            {
                Pharmacy = new Pharmacy();
            }

            if (Pharmacy == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Pharmacy pharmacy)
        {
            if (Pharmacy.PharmacyId > 0)
            {
                Pharmacy = pharmaciesRepository.Update(pharmacy);
            }
            else
            {
                Pharmacy = pharmaciesRepository.Add(pharmacy);
            }

            return RedirectToPage("/Pharmacies/Pharmacies");
        }
    }
}
