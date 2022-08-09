using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRazorLabb.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data Books
            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Title = "IT", Author = "Stephen King", IsAvailable = true});
            modelBuilder.Entity<Book>().HasData(new Book { Id = 2, Title = "Jakten på miljonerna", Author = "100miljonersmannen", IsAvailable = true});
            modelBuilder.Entity<Book>().HasData(new Book { Id = 3, Title = "Gränslöst", Author = "Jørn Lier Horst", IsAvailable = true});
            modelBuilder.Entity<Book>().HasData(new Book { Id = 4, Title = "Ugly Love", Author = "Colleen Hoover", IsAvailable = true });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 5, Title = "Yani", Author = "Nora Khalil", IsAvailable = true });


            //Seed Data Customer
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 1, FirstName = "Jeremy", LastName = "Cedendahl", Email = "jeremy@jerm.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 2, FirstName = "Johan", LastName = "Larsson", Email = "johan@johan.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 3, FirstName = "Jesper", LastName = "Andersson", Email = "jandersson@halloj.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 4, FirstName = "Ida", LastName = "Johansson", Email = "idaj@yahoo.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 5, FirstName = "Anton", LastName = "Johansson", Email = "atom@live.se" });




        }
    }
}
