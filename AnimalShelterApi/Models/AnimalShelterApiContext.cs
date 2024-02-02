using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Matilda", Species = "Dog", Age = 7, Gender = "Female" },
          new Animal { AnimalId = 2, Name = "Rexie", Species = "Cat", Age = 10, Gender = "Female"},
          new Animal { AnimalId = 3, Name = "Opil", Species = "Cat", Age = 2, Gender = "Female"},
          new Animal { AnimalId = 4, Name = "Pip", Species = "Dog", Age = 4, Gender = "Male"},
          new Animal { AnimalId = 5, Name = "Baetholomew", Species = "Cat", Age = 6, Gender = "Male"}
        );
    }
  }
}