using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SubCategoryManager subCategoryManager = new SubCategoryManager(new EfSubCategoryDal());
            var result = subCategoryManager.GetAll().Data;
            foreach (var brand in result)
            {
                Console.WriteLine(brand.SubCategoryId + "/" + brand.SubCategoryName);
            }
        }
    }
}
