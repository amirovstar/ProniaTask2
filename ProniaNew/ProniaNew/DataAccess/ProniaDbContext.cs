﻿ using System;
using Microsoft.EntityFrameworkCore;
using ProniaNew.Models;

namespace ProniaNew.DataAccess;
public class ProniaDbContext : DbContext
{
    public ProniaDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Setting> Settings { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasIndex(p => p.Name).IsUnique();
        base.OnModelCreating(modelBuilder);
    }
}

