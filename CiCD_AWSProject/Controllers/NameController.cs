using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CiCD_AWSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            string name = "Hello";
            return name;    
        }
    }
}
