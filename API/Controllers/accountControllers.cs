using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class accountControllers : ControllerBase
    {
        [HttpGet]
        public string Hi()
        {
            return "Hi";
        }
    }
}
