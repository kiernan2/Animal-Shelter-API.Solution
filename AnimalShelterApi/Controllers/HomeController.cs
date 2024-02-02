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
  public class HomeController : Controller
  {
    private readonly AnimalShelterApiContext _db;

    public HomeController(AnimalShelterApiContext db)
    {
      _db = db;
    }
  }
}