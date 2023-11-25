using RazorModels;

namespace RazorServices
{
    public class SqlPharmaciesRepository : IPharmaciesRepository
    {
        private AppDbContext __db;

        public SqlPharmaciesRepository(AppDbContext db)
        {
            __db = db;
        }

        public Pharmacy Add(Pharmacy pharmacy)
        {
            throw new NotImplementedException();
        }

        public Pharmacy Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pharmacy> GetAllPharmacies()
        {
            throw new NotImplementedException();
        }

        public Pharmacy? GetPharmacy(int id)
        {
            throw new NotImplementedException();
        }

        public Pharmacy Update(Pharmacy uPharmacy)
        {
            throw new NotImplementedException();
        }
    }
}

