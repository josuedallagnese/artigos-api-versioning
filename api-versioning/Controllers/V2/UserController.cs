using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/users")]
    public class UserController : Controller
    {
        [HttpGet]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
