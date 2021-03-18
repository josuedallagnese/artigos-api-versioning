using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.HeaderValue.V2
{
    /// <summary>
    /// Work's with HeaderValue versioning
    /// </summary>
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/reviewers")]
    public class ReviewerController : Controller
    {
        [HttpGet, MapToApiVersion("2.0")]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();

        [HttpGet, MapToApiVersion("3.0")]
        public string GetV3() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
