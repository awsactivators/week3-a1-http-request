using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class SecretController : ControllerBase
  {
    /// <summary>
    /// Acknowledgement of the secret integer
    /// </summary>
    /// <param name="secret">The secret integer</param>
    /// <returns>A message acknowledging the secret</returns>
    /// <example>
    /// GET: localhost:5169/api/Secret/secret -> "Shh.. the secret is {secret}"
    /// </example>

    [HttpPost(template:"secret")]
    public string Secret([FromBody] int secret)
    {
        return $"Shh.. the secret is {secret}";
    }

  }

}