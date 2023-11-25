using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Pharmacies
{
    public class PharmaciesModel : PageModel
    {
        private IPharmaciesRepository __db;

        public PharmaciesModel(IPharmaciesRepository db)
        {
            __db = db;
        }

        public IEnumerable<Pharmacy> Pharmacies { get; set; }

        public void OnGet()
        {
            Pharmacies = __db.GetAllPharmacies();
        }
    }
}
