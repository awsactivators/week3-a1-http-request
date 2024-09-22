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
    /// POST: localhost:5169/api/SquashFellows/squashfellows
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
