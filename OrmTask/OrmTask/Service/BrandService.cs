using Microsoft.Identity.Client;
using OrmTask.DAL;
using OrmTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrmTask.Service
{
    internal class BrandService : IBrandService
    {
        public void Create(Brand brand)
        {
            var dataContext = new DataContext();
            var existBrand = dataContext.Brands.FirstOrDefault(b => b.Name == brand.Name);
            if (existBrand != null)
            {
                Console.WriteLine($"{brand.Name} Nameli car artiq movcuddur....");
                return;
            }
            dataContext.Brands.Add(brand);
            dataContext.SaveChanges();
        }
        public void Update(int? id, string name)
        {
            if (id == null)
            {
                Console.WriteLine("Id null ola bilmez");
                return;
            }
            var dataContext = new DataContext();
            var existBrand = dataContext.Brands.Find(id);
            if (existBrand == null)
            {
                Console.WriteLine($"{id}=>Id-li brand movcud deyil....");
                return;
            }
            existBrand.Name = name;
            dataContext.SaveChanges();
        }
        public void Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Id null ola bilmez....");
                return;
            }
            var dataContext = new DataContext();
            var existBrand = dataContext.Brands.Find(id);
            if (existBrand == null)
            {
                Console.WriteLine($"{id}=>Id-li brand yoxdur.... ");
                return;
            }
            dataContext.Brands.Remove(existBrand);
            dataContext.SaveChanges();
        }
        public List<Brand> Get()
        {
            var dataContext = new DataContext();
            return dataContext.Brands.ToList();
        }
        public Brand GetById(int id)
        {
            var dataContext = new DataContext();
            return dataContext.Brands.Find(id);
        }
    }
}
