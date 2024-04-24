using OrmTask.Models;

namespace OrmTask.Service
{
    internal interface IBrandService
    {
        void Create(Brand brand);
        void Delete(int? id);
        List<Brand> Get();
        void Update(int? id, string name);
    }
}