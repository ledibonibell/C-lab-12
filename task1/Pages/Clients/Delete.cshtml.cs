using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        private IClientsRepository __db;
        public DeleteModel(IClientsRepository db)
        {
            __db = db;
        }

        [BindProperty]
        public Client Client { get; set; }

        public IActionResult OnGet(int id)
        {
            Client = __db.GetClient(id);
            if (Client == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Client = __db.Delete(Client.ClientId);
            if (Client == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Clients/Clients");
        }
    }
}
