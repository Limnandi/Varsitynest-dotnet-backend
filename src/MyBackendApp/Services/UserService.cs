using System.Collections.Generic;
using MyBackendApp.Models;

namespace MyBackendApp.Services
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            // Mock implementation
            return new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@example.com" }
            };
        }
    }
}