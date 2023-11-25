using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Medicines
{
    public class DeleteModel : PageModel
    {
        private IMedicinesRepository __db;
        public DeleteModel(IMedicinesRepository db)
        {
            __db = db;
        }

        [BindProperty]
        public Medicine Medicine { get; set; }

        public IActionResult OnGet(int id)
        {
            Medicine = __db.GetMedicine(id);
            if (Medicine == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Medicine = __db.Delete(Medicine.MedicineId);
            if (Medicine == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Medicines/Medicines");
        }
    }
}
