using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContextFactory : IDesignTimeDbContextFactory<AnimalShelterApiContext>
  {

    AnimalShelterApiContext IDesignTimeDbContextFactory<AnimalShelterApiContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.Development.json")
        .Build();

      DbContextOptionsBuilder<AnimalShelterApiContext> builder = new DbContextOptionsBuilder<AnimalShelterApiContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new AnimalShelterApiContext(builder.Options);
    }
  }
}