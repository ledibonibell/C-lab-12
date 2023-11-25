using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Medicines
{
    public class MedicinesModel : PageModel
    {
        private IMedicinesRepository __db;

        public MedicinesModel(IMedicinesRepository db)
        {
            __db = db;
        }

        public IEnumerable<Medicine> Medicines { get; set; }

        public void OnGet()
        {
            Medicines = __db.GetAllMedicines();
        }
    }
}
