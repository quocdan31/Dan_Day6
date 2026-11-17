using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dan_Day6.Data;
using System;
using System.Linq;

namespace Dan_Day6.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Dan_Day6Context(
            serviceProvider.GetRequiredService<DbContextOptions<Dan_Day6Context>>()))
        {
            // Seed Movies
            if (!context.Movie.Any())
            {
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Trai Buon Co",
                        ReleaseDate = DateTime.Parse("2026-07-12"),
                        Genre = "Phim hanh dong",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Meo Meo",
                        ReleaseDate = DateTime.Parse("2026-08-12"),
                        Genre = "Phim hai",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Gau Meo",
                        ReleaseDate = DateTime.Parse("2026-09-12"),
                        Genre = "Phim hai",
                        Price = 13.99M
                    },
                    new Movie
                    {
                        Title = "Gau Gau",
                        ReleaseDate = DateTime.Parse("2005-10-12"),
                        Genre = "Phim hai",
                        Price = 14.99M
                    }
                );
            }

            // Seed Products
            if (!context.Product.Any())
            {
                context.Product.AddRange(
                    new Product
                    {
                        Name = "Laptop Gaming ASUS",
                        Price = 1200.00M,
                        Quantity = 10
                    },
                    new Product
                    {
                        Name = "Bàn phím cơ Logitech",
                        Price = 85.50M,
                        Quantity = 30
                    },
                    new Product
                    {
                        Name = "Chuột không dây Razer",
                        Price = 55.00M,
                        Quantity = 25
                    }
                );
            }

            context.SaveChanges();
        }
    }
}
