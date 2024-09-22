using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class GreetingController : ControllerBase
  {
    /// <summary>
    /// Returns a greeting to the specified name
    /// </summary>
    /// <param name="name">The user's name</param>
    /// <returns>A greeting message with a dynamic name</returns>
    /// <example>
    /// GET: localhost:5169/api/Greeting/greeting?name=Gary -> "Hi Gary!"
    /// GET: localhost:5169/api/Greeting/greeting?name=Ren%C3%A9e -> "Hi Renée!"
    /// </example>

    [HttpGet(template:"greeting")]
    public string Greeting(string name)
    {
      return $"Hi {name}!";
    }
  }

}