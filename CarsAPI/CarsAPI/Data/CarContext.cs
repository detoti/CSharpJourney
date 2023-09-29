using System;
using CarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsAPI.Data;

public class CarContext : DbContext
{
    public CarContext(DbContextOptions<CarContext> opts) : base(opts)
    {

    }

    public DbSet<Carro> Carros { get; set; }
}

