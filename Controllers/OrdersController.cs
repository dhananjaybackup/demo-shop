using Microsoft.AspNetCore.Mvc;

namespace DemoBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
 static List<Order> _orders = new();

    [HttpPost]
    public IActionResult Create(Order order)
    {
        _orders.Add(order);
        return Ok(order);
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_orders);
    }

    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok("Backend alive");
    }
}

public class Order
{
    public Guid Id { get; set; }
    public string email { get; set; }
    public decimal amount { get; set; }
}
