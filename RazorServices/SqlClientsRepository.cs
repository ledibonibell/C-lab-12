using RazorModels;

namespace RazorServices
{
    public class SqlClientsRepository : IClientsRepository
    {
        private AppDbContext __db;

        public SqlClientsRepository(AppDbContext db)
        {
            __db = db;
        }

        public Client Add(Client client)
        {
            __db.Clients.Add(client);
            __db.SaveChanges();
            return client;
        }

        public Client Delete(int id)
        {
            var passToDel = __db.Clients.Find(id);

            if (passToDel != null)
            {
                __db.Clients.Remove(passToDel);
                __db.SaveChanges();
            }
            return passToDel;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return __db.Clients;
        }

        public Client? GetClient(int id)
        {
            return __db.Clients.Find(id);
        }

        public Client Update(Client uClient)
        {
            var pass = __db.Clients.Attach(uClient);
            pass.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            __db.SaveChanges();
            return uClient;
        }
    }
}

