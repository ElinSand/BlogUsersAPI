using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogUsersAPI.Data;
using BlogUsersAPI.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace BlogUsersAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

    
        private readonly UserDbContext _dbContext;


        public UserController(UserDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

    }
}
