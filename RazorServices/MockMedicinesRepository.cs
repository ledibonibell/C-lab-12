using System;
using RazorModels;

namespace RazorServices
{
	public class MockMedicinesRepository : IMedicinesRepository
    {
        List<Medicine> __medicines { get; set; }
		public MockMedicinesRepository()
		{
            __medicines = new List<Medicine>()
            {
                new Medicine()
                {
                    MedicineId = 0,
                    Price = 69
                },
                new Medicine()
                {
                    MedicineId = 1,
                    Price = 999
                },
                new Medicine()
                {
                    MedicineId = 2,
                    Price = 1
                }
            };
		}

        public Medicine Add(Medicine medicine)
        {
            medicine.MedicineId = __medicines.Max(x => x.MedicineId) + 1;
            __medicines.Add(medicine);
            return medicine;
        }

        public Medicine Delete(int id)
        {
            var medicine = __medicines.FirstOrDefault(p => p.MedicineId == id);
            if (medicine != null)
            {
                __medicines.Remove(medicine);
            }
            return medicine;
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return __medicines;
        }

        public Medicine? GetMedicine(int id)
        {
            return __medicines.FirstOrDefault(p => p.MedicineId == id);
        }

        public Medicine Update(Medicine uMedicine)
        {
            Medicine medicine = __medicines.FirstOrDefault(t => t.MedicineId == uMedicine.MedicineId);
            if (medicine != null)
            {
                medicine.Price = uMedicine.Price;
            }
            return medicine;
        }
    }
}

