using System;
using RazorModels;

namespace RazorServices
{
    public class MockClientsRepository : IClientsRepository
    {
        List<Client> __clients { get; set; }
        public MockClientsRepository()
        {
            __clients = new List<Client>()
            {
                new Client()
                {
                    ClientId = 0,
                    Name = "Egor1"
                },
                new Client()
                {
                    ClientId = 1,
                    Name = "Egor2"
                },
                new Client()
                {
                    ClientId = 2,
                    Name = "Egor100000000"
                }
            };
        }

        public Client Add(Client client)
        {
            client.ClientId = __clients.Max(x => x.ClientId) + 1;
            __clients.Add(client);
            return client;
        }

        public Client Delete(int id)
        {
            var client = __clients.FirstOrDefault(p => p.ClientId == id);
            if (client != null)
            {
                _ = __clients.Remove(client);
            }
            return client;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return __clients;
        }

        public Client? GetClient(int id)
        {
            return __clients.FirstOrDefault(p => p.ClientId == id);
        }

        public Client Update(Client uClient)
        {
            Client pass = __clients.FirstOrDefault(p => p.ClientId == uClient.ClientId);
            if (pass != null)
            {
                pass.Name = uClient.Name;
            }
            return pass;
        }
    }
}

