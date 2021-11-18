using EFCoreExample.Database;
using EFCoreExample.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SMECommerceDbContext db = new SMECommerceDbContext();
            //Category category = new Category();
            //category.Name = "Home Applines";

            Category category1 = new Category()
            {
                Name = "Electronics"
            };
           

            //Category category3 = new Category();
            //category3.Name = "Sports";
            //var CategoryList = new[]
            //{
            //    new Category(){Name="Vehicles"},
            //    new Category(){Name="Stationaries"}
            //};

            //db.AddRange(CategoryList);
            var brands = new List<Brand>()
            {
                new Brand()
                {
                    Name = "Singer"
                   
                },
                new Brand()
                {
                    Name = "Walton"
                   
                }
            };
            category1.Brands = brands;
            db.Categories.Add(category1);

            int successCount = db.SaveChanges();
            if (successCount > 0)
            {
                Console.WriteLine($"Save Successfully {successCount} Times.");
            }
            else
            {
                Console.WriteLine($"Something Went Wrong!!");
            }

            var categories = db.Categories;
            int i = 0;
            foreach (var item in categories)
            {
                Console.WriteLine($"[{++i}] Id:{item.Id} Name:{item.Name}");
            }


            //---------------
            //Console.WriteLine("Getting an object...");
            //var id = int.Parse(Console.ReadLine());

            //var categoryObj = categories.Where(x => x.Id == id).FirstOrDefault();

            //Console.WriteLine($"Category Details:{categoryObj.Id}-{categoryObj.Name}");
            //Console.WriteLine("Change the Name to : ");
            //var name = Console.ReadLine();
            //categoryObj.Name = name;
            //int countSucc = db.SaveChanges();
            //if (countSucc>0)
            //{
            //    Console.WriteLine($"Successfully Updated {countSucc} Times.");
            //}
        }
    }
}
