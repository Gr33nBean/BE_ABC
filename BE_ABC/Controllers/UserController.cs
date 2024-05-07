using foody_be.Models.CommonModels;
using foody_be.Services;
using Microsoft.AspNetCore.Mvc;

namespace foody_be.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService) 
        { 
            _userService = userService;
        }
        [HttpPost]
        [Route("getAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getAll(Pagination pagination)
        {
            try
            {
                var entity = _userService.getAll(pagination);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
