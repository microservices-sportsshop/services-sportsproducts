﻿using Microsoft.EntityFrameworkCore;
using Sports.Data.Entities;

namespace Sports.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "Active Wear - Men" },
                new Category { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Active Wear - Women" },
                new Category { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba413"), Name = "Mineral Water" },
                new Category { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba414"), Name = "Publications" },
                new Category { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Supplements" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba501"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "Grunge Skater Jeans", Sku = "AWMGSJ", Price = 68, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba502"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "Polo Shirt", Sku = "AWMPS", Price = 35, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba503"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "Skater Graphic T-Shirt", Sku = "AWMSGT", Price = 33, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba504"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "Slicker Jacket", Sku = "AWMSJ", Price = 125, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba505"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "Thermal Fleece Jacket", Sku = "AWMTFJ", Price = 60, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba506"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "Unisex Thermal Vest", Sku = "AWMUTV", Price = 95, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba507"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "V-Neck Pullover", Sku = "AWMVNP", Price = 65, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba508"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "V-Neck Sweater", Sku = "AWMVNS", Price = 65, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba509"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba411"), Name = "V-Neck T-Shirt", Sku = "AWMVNT", Price = 17, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba510"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Bamboo Thermal Ski Coat", Sku = "AWWBTSC", Price = 99, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba511"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Cross-Back Training Tank", Sku = "AWWCTT", Price = 0, IsAvailable = false },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba512"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Grunge Skater Jeans", Sku = "AWWGSJ", Price = 68, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba513"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Slicker Jacket", Sku = "AWWSJ", Price = 125, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba514"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Stretchy Dance Pants", Sku = "AWWSDP", Price = 55, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba515"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Ultra-Soft Tank Top", Sku = "AWWUTT", Price = 22, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba516"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "Unisex Thermal Vest", Sku = "AWWUTV", Price = 95, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba518"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba412"), Name = "V-Next T-Shirt", Sku = "AWWVNT", Price = 17, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba519"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba413"), Name = "Blueberry Mineral Water", Sku = "MWB", Price = 2.8M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba520"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba413"), Name = "Lemon-Lime Mineral Water", Sku = "MWLL", Price = 2.8M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba521"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba413"), Name = "Orange Mineral Water", Sku = "MWO", Price = 2.8M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba522"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba413"), Name = "Peach Mineral Water", Sku = "MWP", Price = 2.8M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba523"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba413"), Name = "Raspberry Mineral Water", Sku = "MWR", Price = 2.8M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba524"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba413"), Name = "Strawberry Mineral Water", Sku = "MWS", Price = 2.8M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba525"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba414"), Name = "In the Kitchen with H+ Sport", Sku = "PITK", Price = 24.99M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba526"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Calcium 400 IU (150 tablets)", Sku = "SC400", Price = 9.99M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba527"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Flaxseed Oil 100 mg (90 capsules)", Sku = "SFO100", Price = 12.49M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba528"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Iron 65 mg (150 caplets)", Sku = "SI65", Price = 13.99M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba529"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Magnesium 250 mg (100 tablets)", Sku = "SM250", Price = 12.49M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba530"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Multi-Vitamin (90 capsules)", Sku = "SMV", Price = 9.99M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba531"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Vitamin A 10,000 IU (125 caplets)", Sku = "SVA", Price = 11.99M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba532"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Vitamin B-Complex (100 caplets)", Sku = "SVB", Price = 12.99M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba533"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Vitamin C 1000 mg (100 tablets)", Sku = "SVC", Price = 9.99M, IsAvailable = true },
                new Product { Id = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba534"), CategoryId = Guid.Parse("62042340-8b07-45c7-8e93-70ea318ba415"), Name = "Vitamin D3 1000 IU (100 tablets)", Sku = "SVD3", Price = 12.49M, IsAvailable = true });

        }

    }
}
