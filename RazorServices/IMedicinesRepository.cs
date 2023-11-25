using RazorModels;

namespace RazorServices
{
	public interface IMedicinesRepository
	{
		public IEnumerable<Medicine> GetAllMedicines();
        public Medicine? GetMedicine(int id);
        public Medicine Add(Medicine medicine);
        public Medicine Update(Medicine uMedicine);
        public Medicine Delete(int id);
    }
}

