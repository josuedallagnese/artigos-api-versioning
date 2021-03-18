using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.UrlPath.V1
{
    /// <summary>
    /// Work's with UrlPath versioning
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/posts")]
    public class PostController : Controller
    {
        [HttpGet]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
