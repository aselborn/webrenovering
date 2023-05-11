using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace renovering.Models;
public class ModelContext : DbContext
{
    public DbSet<renovering.Dtos.Users> userDtos {get;set;} = null!;
 
    public string dbPath {get;set;}

    public ModelContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        dbPath = System.IO.Path.Join("C:\\temp\\", "renovering.db");
    }

     protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={dbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}