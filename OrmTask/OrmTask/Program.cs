// See https://aka.ms/new-console-template for more information
using OrmTask.DAL;
using OrmTask.Service;

Console.WriteLine("Hello, World!");

//studentService.Create(new() { Name = "Kenan", Surname = "Quliyev", Age = 21 });

using DataContext dataContext = new();
//dataContext.Brands.AddRange
//    (
//    new() { Name = "OPEL" },                // Coxlu sayda car elave etmek ucun...
//    new() { Name = "JEEP" },
//    new() { Name = "CAMARO" }
//    );
//dataContext.SaveChanges();
//dataContext.Brands.Add(new() { Name = "Porshe" });   // Bir car elave etmek ucun...
//dataContext.SaveChanges();




//dataContext.Brands.Add(new() { Name = "AMG" });
//dataContext.SaveChanges();
//var brands = dataContext.Brands.ToList();
//foreach (var item in brands)
//{
//    Console.WriteLine(item);
//}



//CREATE
//BrandService brandService = new();
//brandService.Create(new() { Name = "AMG" });
//brandService.Create(new() { Name = "AUDI" });
//brandService.Create(new() { Name = "BMW" });
//brandService.Create(new() { Name = "LAMBORJINI" });
//brandService.Create(new() { Name = "FERRARI" });


//UPDATE
//BrandService brandService = new();
//brandService.Update(3, "BUGATTI");


//DELETE
//BrandService brandService = new();
//brandService.Delete(6);


//GET
//BrandService brandService = new BrandService();
//foreach (var item in brandService.Get())
//{
//    Console.WriteLine(item);
//}


//GET.BY.ID
//BrandService brandService = new BrandService();
//Console.WriteLine(brandService.GetById(1));













