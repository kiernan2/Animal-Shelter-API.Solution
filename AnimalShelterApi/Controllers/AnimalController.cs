using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalController : ControllerBase
  {
    private AnimalShelterApiContext _db;

    public AnimalController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId ==id);
    }

    // GET api/animal
    [HttpGet]
    public async Task<List<Animal>> Get(string name, int animalId, string species, string gender, int age)
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if (animalId != 0)
      {
        query = query.Where(entry => entry.AnimalId == animalId);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      return await query.ToListAsync();
    }

    // POST api/animals
    [HttpPost]
    public async Task<ActionResult> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = animal.AnimalId }, animal);
    }

    // GET api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    // PUT: api/Animals/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId});
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}