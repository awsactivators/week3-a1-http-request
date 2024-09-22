using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class CubeController : ControllerBase
  {
    /// <summary>
    /// Returns the cube of the given integer
    /// </summary>
    /// <param name="base">The base integer to calculate the cube</param>
    /// <returns>The cube of the base integer</returns>
    /// <example>
    /// GET: localhost:5169/api/Cube/cube/4 -> 64
    /// GET: localhost:5169/api/Cube/cube/-4 -> -64
    /// GET: localhost:5169/api/Cube/cube/100 -> 1000
    /// </example>

    [HttpGet(template:"cube/{base}")]
    public double Cube(int @base)
    {
        return Math.Pow(@base, 3);
    }

  }

}