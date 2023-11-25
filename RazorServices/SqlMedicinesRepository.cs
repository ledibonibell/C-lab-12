using RazorModels;

namespace RazorServices
{
    public class SqlMedicinesRepository : IMedicinesRepository
    {
        private AppDbContext __db;

        public SqlMedicinesRepository(AppDbContext db)
        {
            __db = db;
        }

        public Medicine Add(Medicine medicine)
        {
            throw new NotImplementedException();
        }

        public Medicine Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            throw new NotImplementedException();
        }

        public Medicine? GetMedicine(int id)
        {
            throw new NotImplementedException();
        }

        public Medicine? GetMedicines(int id)
        {
            throw new NotImplementedException();
        }

        public Medicine Update(Medicine uMedicine)
        {
            throw new NotImplementedException();
        }
    }
}

