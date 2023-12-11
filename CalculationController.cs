using Microsoft.AspNetCore.Mvc;

namespace pr3
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calcService;
        public CalculationController(ICalculationService calculationController) { _calcService = calculationController; }

        [HttpGet("add/{a}/{b}")]
        public ActionResult<int> Add(int a, int b) => _calcService.Sum(a, b);

        [HttpGet("subtract/{a}/{b}")]
        public ActionResult<int> Subtract(int a, int b) => _calcService.Substract(a, b);

        [HttpGet("multiply/{a}/{b}")]
        public ActionResult<int> Multiply(int a, int b) => _calcService.Multiply(a, b);

        [HttpGet("divide/{a}/{b}")]
        public ActionResult<double> Divide(int a, int b) => b != 0 ? _calcService.Divide(a, b): BadRequest("Cannot divide by zero.");
    }
}