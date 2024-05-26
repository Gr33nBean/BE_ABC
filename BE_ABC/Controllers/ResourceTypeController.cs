using BE_ABC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_ABC.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ResourceTypeController : Controller
    {
        private readonly ResourceTypeService ResourceTypeService;
        public ResourceTypeController(ResourceTypeService ResourceTypeService)
        {
            this.ResourceTypeService = ResourceTypeService;
        }
    }
}
