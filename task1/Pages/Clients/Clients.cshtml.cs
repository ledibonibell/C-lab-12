using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Clients
{
    public class ClientsModel : PageModel
    {
        private readonly IClientsRepository __db;

        public ClientsModel(IClientsRepository db)
        {
            __db = db;
        }

        public IEnumerable<Client> Clients { get; set; }

        public void OnGet()
        {
            Clients = __db.GetAllClients();
        }
    }
}
