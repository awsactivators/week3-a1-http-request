using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class KnocKnockController : ControllerBase
  {
    /// <summary>
    /// Returns the start of a knock knock joke
    /// </summary>
    /// <param name="">No parameter used</param>
    /// <returns>A "Who's there?" message</returns>
    /// <example>
    /// GET: localhost:5169/api/KnockKnock/knockknock -> "Who's there?"
    /// </example>

    [HttpPost(template: "knockknock")]
    public string KnockKnock()
    {
        return "Who's there?";
    }

  }

}