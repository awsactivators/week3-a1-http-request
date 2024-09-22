using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class TimeMachineController : ControllerBase
  {
    /// <summary>
    /// Returns the date adjusted by the specified number of days
    /// </summary>
    /// <param name="days">The number of days to adjust the current date by</param>
    /// <returns>The adjusted date as a string yyyy-mm-dd</returns>
    /// <example>
    /// GET: localhost:5169/api/TimeMachine/timemachine?days=1  -> "2000-01-02"
    /// GET: localhost:5169/api/TimeMachine/timemachine?days=-1  -> "1999-12-31"
    /// </example>

    [HttpGet(template:"timemachine")]
    public string TimeMachine(int days)
    {
        var resultDate = DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
        return resultDate;
    }

  }

}