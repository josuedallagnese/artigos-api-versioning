using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.HeaderValue.V1
{
    /// <summary>
    /// Work's with HeaderValue versioning
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/reviewers")]
    public class ReviewerController : Controller
    {
        [HttpGet]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
