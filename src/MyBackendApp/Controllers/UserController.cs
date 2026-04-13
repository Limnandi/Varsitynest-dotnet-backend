using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyBackendApp.Models;

namespace MyBackendApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> Get()
        {
            // Mock data
            return new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@example.com" }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            // Mock
            return new User { Id = id, Name = "John Doe", Email = "john@example.com" };
        }
    }
}