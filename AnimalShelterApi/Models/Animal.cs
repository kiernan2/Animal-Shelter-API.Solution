using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(3)]
    public string Species { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public virtual ApplicationUser User { get; set; }
  }
}