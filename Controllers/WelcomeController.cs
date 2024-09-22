using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class WelcomeController : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message
        /// </summary>
        /// <param name="">No parameter needed</param>
        /// <returns>A welcome message string "Welcome to 5125!"</returns>
        /// <example>
        /// GET: localhost:5169/api/Welcome/welcome -> "Welcome to 5125!"
        /// </example>
        /// 

        [HttpGet(template:"welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }

}