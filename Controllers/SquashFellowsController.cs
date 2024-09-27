using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a1_http_request.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SquashFellowsController : ControllerBase
  {
    /// <summary>
    /// Returns a summary of the order for SquashFellows
    /// </summary>
    /// <param name="small">Number of small plushies</param>
    /// <param name="large">Number of large plushies</param>
    /// <returns>Checkout summary with total cost</returns>
    /// <example>
    /// POST localhost/api/SquashFellows/squashfellows
    /// Content-Type:application/x-www-form-urlencoded
    /// REQUEST BODY: Small=1&Large=1 -> 1 Small @ $25.50 = $25.50; 1 Large @ $45.50 = $45.50; Subtotal = $71.00; Tax = $9.23 HST; Total = $80.23
    /// POST localhost/api/SquashFellows/squashfellows
    /// Content-Type:application/x-www-form-urlencoded
    /// REQUEST BODY: Small=2&Large=1 -> 2 Small @ $25.50 = $51.00; 1 Large @ $45.50 = $45.50; Subtotal = $96.50; Tax = $12.54 HST; Total = $109.04
    /// POST localhost/api/SquashFellows/squashfellows
    /// Content-Type:application/x-www-form-urlencoded
    /// REQUEST BODY: Small=100&Large=100 -> 100 Small @ $25.50 = $2550.00; 100 Large @ $45.50 = $4550.00; Subtotal = $7100.00; Tax = $923.00 HST; Total = $8023.00 
    /// </example>

    [HttpPost(template:"squashfellows")]
    [Consumes("application/x-www-form-urlencoded")]
    public string SquashFellows([FromForm] int small, [FromForm] int large)
    {
        const double smallPrice = 25.50;
        const double largePrice = 45.50;
        const double taxRate = 0.13;

        double smallCost = small * smallPrice;
        double largeCost = large * largePrice;
        double subtotal = smallCost + largeCost;
        double tax = Math.Round(subtotal * taxRate, 2);
        double total = Math.Round(subtotal + tax, 2);

        string summary = $"{small} Small @ ${smallPrice:F2} = ${smallCost:F2}; " +
                         $"{large} Large @ ${largePrice:F2} = ${largeCost:F2}; " +
                         $"Subtotal = ${subtotal:F2}; Tax = ${tax:F2} HST; Total = ${total:F2}";

        return summary;
    }
  }
}
