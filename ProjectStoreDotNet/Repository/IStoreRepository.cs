using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectStoreDotNet.Models;

namespace ProjectStoreDotNet.Repository
{
    public interface IStoreRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartmentById(int id);
        void AddDepartment(Department department);
        void DeleteDepartment(Department department);
        IEnumerable<Seller> GetSellers();
        Seller GetSellerById(int id);
        void AddSeller(Seller seller);
        void DeleteSeller(Seller seller);


    }
}
