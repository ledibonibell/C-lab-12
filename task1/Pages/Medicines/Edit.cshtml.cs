using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Medicines
{
    public class EditModel : PageModel
    {
        private readonly IMedicinesRepository medicinesRepository;

        public EditModel(IMedicinesRepository medicinesRepository)
        {
            this.medicinesRepository = medicinesRepository;
        }

        [BindProperty]
        public Medicine Medicine { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Medicine = medicinesRepository.GetMedicine(id.Value);
            }
            else
            {
                Medicine = new Medicine();
            }

            if (Medicine == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Medicine medicine)
        {
            if (Medicine.MedicineId > 0)
            {
                Medicine = medicinesRepository.Update(medicine);
            }
            else
            {
                Medicine = medicinesRepository.Add(medicine);
            }

            return RedirectToPage("/Medicines/Medicines");
        }
    }
}
