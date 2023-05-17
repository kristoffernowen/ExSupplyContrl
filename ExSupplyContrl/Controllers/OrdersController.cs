using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExSupplyContrl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult Create(string content)
        {
            try
            {
                _orderService.Create(content);

                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Problem("Fungerade inte");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _orderService.Get();

            return result.Any() ? Ok(result) : NotFound();
        }
    }
}
