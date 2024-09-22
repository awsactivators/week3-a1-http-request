using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class HexagonController : ControllerBase
  {
    /// <summary>
    /// Returns the area of a regular hexagon with side length double {S}
    /// </summary>
    /// <param name="side">The side length of the hexagon</param>
    /// <returns>The area of the hexagon</returns>
    /// <example>
    /// GET: localhost:5169/api/Hexagon/hexagon?side=1  -> "2.598076211353316"
    /// GET: localhost:5169/api/Hexagon/hexagon?side=1.5  -> "5.845671475544961"
    /// GET: localhost:5169/api/Hexagon/hexagon?side=10  -> "1039.2304845413264"
    /// </example>

    [HttpGet(template:"hexagon")]
    public double Hexagon(double side)
    {
        double area = 3 * Math.Sqrt(3) / 2 * Math.Pow(side, 2);
        return area;
    }

  }

}