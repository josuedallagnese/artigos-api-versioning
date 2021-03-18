using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/users")]
    [Route("api/v{version:apiVersion}/users")]
    public class UserController : Controller
    {
        [HttpGet]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
