using DataBase.Data;
using Microsoft.AspNetCore.Mvc;

namespace DataBase.Controller
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public UserController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult TestDatabaseConnection()
        {
            try
            {
                // 尝试从数据库中获取第一个用户
                var user = _context.Users.FirstOrDefault();

                if (user != null)
                {
                    return Ok($"Successfully fetched user with ID: {user.Id} and Name: {user.Name}");
                }
                else
                {
                    return Ok("Connected to database, but no users found.");
                }
            }
            catch (Exception ex)
            {
                // 返回错误信息
                return BadRequest($"Error connecting to database: {ex.Message}");
            }
        }
    }
}