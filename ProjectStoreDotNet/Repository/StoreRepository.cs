using ProjectStoreDotNet.Models;

namespace ProjectStoreDotNet.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly IStoreContext _context;

        public StoreRepository(IStoreContext context)
        {
            _context = context;
        }

        void IStoreRepository.AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        void IStoreRepository.AddSeller(Seller seller)
        {
            _context.Sellers.Add(seller);
            _context.SaveChanges();
        }

        void IStoreRepository.DeleteDepartment(Department department)
        {
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }

        void IStoreRepository.DeleteSeller(Seller seller)
        {
            _context.Sellers.Remove(seller);
            _context.SaveChanges();
        }

        Department IStoreRepository.GetDepartmentById(int id)
        {
            return _context.Departments.Find(id)!;
        }

        IEnumerable<Department> IStoreRepository.GetDepartments()
        {
            return _context.Departments.ToList();
        }

        Seller IStoreRepository.GetSellerById(int id)
        {
            return _context.Sellers.Find(id)!;
        }

        IEnumerable<Seller> IStoreRepository.GetSellers()
        {
            return _context.Sellers.ToList();
        }
    }
}
