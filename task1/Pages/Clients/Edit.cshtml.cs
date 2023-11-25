using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Clients
{
    public class EditModel : PageModel
    {
        private readonly IClientsRepository clientsRepository;

        public EditModel(IClientsRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
        }

        [BindProperty]
        public Client Client { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Client = clientsRepository.GetClient(id.Value);
            } else
            {
                Client = new Client();
            }

            if (Client == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Client client)
        {
            if (Client.ClientId > 0)
            {
                Client = clientsRepository.Update(client);
            } else
            {
                Client = clientsRepository.Add(client);
            }

            return RedirectToPage("/Clients/Clients");
        }
    }
}
