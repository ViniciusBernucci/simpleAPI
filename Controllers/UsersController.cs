using Microsoft.AspNetCore.Mvc;
using UserManagementApi.Models;

namespace UserManagementApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase {
        private static List<User> _users = new();
        private static int _idCounter = 1;

        [HttpGet] public IActionResult GetAll() => Ok(_users);

        [HttpPost] public IActionResult Create(User user) {
            user.Id = _idCounter++;
            _users.Add(user);
            return CreatedAtAction(nameof(GetAll), new { id = user.Id }, user);
        }

        [HttpPut("{id}")] public IActionResult Update(int id, User updated) {
            var user = _users.Find(u => u.Id == id);
            if (user == null) return NotFound();
            user.Name = updated.Name; user.Email = updated.Email;
            return NoContent();
        }

        [HttpDelete("{id}")] public IActionResult Delete(int id) {
            var user = _users.Find(u => u.Id == id);
            if (user == null) return NotFound();
            _users.Remove(user);
            return NoContent();
        }
    }
}