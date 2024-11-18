﻿using Microsoft.EntityFrameworkCore;
using ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Data
{
    class ProductCategoryContext : DbContext
    {
        public DbSet<Article> Article { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProductCategory;Integrated Security=true; Encrypt=True;Trust Server Certificate=True");
        }
    }
}