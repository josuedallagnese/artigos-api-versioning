using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.QueryString.V2
{
    /// <summary>
    /// Work's with QueryString versioning
    /// </summary>
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/blogs")]
    public class BlogController : Controller
    {
        [HttpGet, MapToApiVersion("2.0")]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();

        [HttpGet, MapToApiVersion("3.0")]
        public string GetV3() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
