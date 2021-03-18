using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.QueryString.V1
{
    /// <summary>
    /// Work's with QueryString versioning
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/blogs")]
    public class BlogController : Controller
    {
        [HttpGet]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
