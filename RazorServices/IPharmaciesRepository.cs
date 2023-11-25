using RazorModels;

namespace RazorServices
{
    public interface IPharmaciesRepository
    {
        public IEnumerable<Pharmacy> GetAllPharmacies();
        public Pharmacy? GetPharmacy(int id);
        public Pharmacy Add(Pharmacy pharmacy);
        public Pharmacy Update(Pharmacy uPharmacy);
        public Pharmacy Delete(int id);
    }
}

