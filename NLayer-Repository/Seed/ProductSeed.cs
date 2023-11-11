using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Repository.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Uçlu Kalem",
                    Price = 10,
                    Stock = 200,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Kurşun Kalem",
                    Price = 3,
                    Stock = 450,
                    CreatedDate = DateTime.Now,
                }, new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Tükenmez Kalem",
                    Price = 22,
                    Stock = 120,
                    CreatedDate = DateTime.Now,
                },
                 new Product
                 {
                     Id = 4,
                     CategoryId = 2,
                     Name = "Matematik",
                     Price = 10,
                     Stock = 200,
                     CreatedDate = DateTime.Now,
                 },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Name = "Fizik",
                    Price = 3,
                    Stock = 450,
                    CreatedDate = DateTime.Now,
                }, new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Name = "Kimya",
                    Price = 22,
                    Stock = 120,
                    CreatedDate = DateTime.Now,
                },
                  new Product
                  {
                      Id = 7,
                      CategoryId = 3,
                      Name = "Spiralli Defter",
                      Price = 10,
                      Stock = 200,
                      CreatedDate = DateTime.Now,
                  },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Name = "Spiralsiz Defter",
                    Price = 3,
                    Stock = 450,
                    CreatedDate = DateTime.Now,
                }, new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Name = "Resim Defteri",
                    Price = 22,
                    Stock = 120,
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
