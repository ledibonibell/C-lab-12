using RazorModels;

namespace RazorServices
{
    public interface IClientsRepository
    {
        public IEnumerable<Client> GetAllClients();
        public Client? GetClient(int id);
        public Client Add(Client client);
        public Client Update(Client uClient);
        public Client Delete(int id);
    }
}

