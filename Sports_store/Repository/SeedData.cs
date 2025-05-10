using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Sports_store.Models;

namespace Sports_store.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context) {

            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                BrandModel nike = new BrandModel { Name = "Nike", Slug = "nike", Description = "Nike la 1 trong nhung hang lon  tren the gioi", Status = 1 };
                BrandModel adidas = new BrandModel { Name = "Adidas ", Slug = "adidas ", Description = "Adidas la 1 trong nhung hang lon  tren the gioi", Status = 1 };
                CategoryModel giay = new CategoryModel { Name = "Giay", Slug = "giay", Description = "Giay la 1 san pham the thao lon  tren the gioi", Status = 1 };
                CategoryModel ao = new CategoryModel { Name = "Ao ", Slug = "ao ", Description = "Ao la 1 san pham the thao lon  tren the gioi", Status = 1 }; 
                _context.Products.AddRange(
                    
                    new ProductDetailModel { Name = "Nike Mercurial", Slug = "Nike Mercurial", Description = "Nike Mercurial là dòng giày được định hướng là dòng giày trợ tốc có trọng lượng nhẹ nhất của Nike", Image = "1.img", Brand = nike, Category = giay, Price = 1150000 },
                    new ProductDetailModel { Name = "Shooter HYC", Slug = "Shooter HYC", Description = "Áo shooter HYC họa tiết toàn thân (Dành cho mọi giới tính)", Image = "2.img", Brand = adidas, Category = ao, Price = 2000000 }
                    );
                    _context.SaveChanges();
            }

        }
    }
}
