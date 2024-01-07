using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HarjoitusTyoBackEnd.Models;
using HarjoitusTyoBackEnd.Services;


namespace HarjoitusTyoBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //TODO: Remove _context
       
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
           
            _service = service;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
         return Ok(await _service.GetUsersAsync());
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            UserDTO dto = await _service.GetUserAsync(id);
            if(dto == null)
            {
                return NotFound();
            }
            return Ok(dto);

    
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(long id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if(await _service.UpdateUserAsync(user))
            {
                return NoContent();
            }
            return NotFound();
     
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserDTO>> PostUser(User user)

        {
            UserDTO? newUser = await _service.NewUserAsync(user);

            if(newUser ==null)
            {
                return Problem("Username not available. Choose different username");
            }
           

            return CreatedAtAction("NewUser", newUser);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(long id)
        {
            if (await _service.DeleteUserAsync(id))
            {
                return NoContent();

            }
            return NotFound();
        }
    }
}
