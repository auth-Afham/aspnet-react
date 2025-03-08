// Controllers/UserController.cs
using Microsoft.AspNetCore.Mvc;
using MyAspNetReactApp.Models;

namespace MyAspNetReactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }
    }
}
