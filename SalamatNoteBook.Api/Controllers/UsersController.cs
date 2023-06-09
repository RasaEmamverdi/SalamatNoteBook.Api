using Microsoft.AspNetCore.Mvc;
using SalamatNoteBook.DataService.Data;
using SalamatNoteBook.Entities.DbSet;
using SalamatNoteBook.Entities.Dtos.Incoming;

namespace SalamatNoteBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly AppDdbContext _db;
        public UsersController(AppDdbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _db.Users.Where(x => x.Status == 1).ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult AddUser(UserDto user)
        {
            var _user = new User
            {
                FirstName = user.FirstName
                ,
                LastName = user.LastName
                ,
                Email = user.Email
                ,
                DateOfBirth = Convert.ToDateTime(user.DateOfBirth)
                ,
                Phone = user.Phone
                ,
                Country=user.Country
                ,
                Status = 1
            };
            _db.Users.Add(_user);
            _db.SaveChanges();
            return Ok();
        }
        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUserById(Guid id)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }

    }
}
