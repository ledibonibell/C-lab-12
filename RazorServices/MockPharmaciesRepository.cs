using System;
using RazorModels;

namespace RazorServices
{
	public class MockPharmaciesRepository : IPharmaciesRepository
	{
		List<Pharmacy> __pharmacies;

		public MockPharmaciesRepository()
		{
            __pharmacies = new List<Pharmacy>()
			{
				new Pharmacy()
				{
                    PharmacyId = 0
				},
				new Pharmacy()
				{
                    PharmacyId = 1
				},
				new Pharmacy()
				{
                    PharmacyId = 2
				}
			};
		}

        public Pharmacy Add(Pharmacy pharmacy)
        {
            pharmacy.PharmacyId = __pharmacies.Max(x => x.PharmacyId) + 1;
            __pharmacies.Add(pharmacy);
            return pharmacy;
        }

        public Pharmacy Delete(int id)
        {
            var pharmacy = __pharmacies.FirstOrDefault(p => p.PharmacyId == id);
            if (pharmacy != null)
            {
                __pharmacies.Remove(pharmacy);
            }
            return pharmacy;
        }

        public IEnumerable<Pharmacy> GetAllPharmacies()
        {
			return __pharmacies;
        }

        public Pharmacy? GetPharmacy(int id)
        {
            return __pharmacies.FirstOrDefault(p => p.PharmacyId == id);
        }

        public Pharmacy Update(Pharmacy uPharmacy)
        {
            Pharmacy pharmacy = __pharmacies.FirstOrDefault(p => p.PharmacyId == uPharmacy.PharmacyId);
            if (pharmacy != null)
            {
                pharmacy.PharmacyId = uPharmacy.PharmacyId;
            }
            return pharmacy;
        }
    }
}

