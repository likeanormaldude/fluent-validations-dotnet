using FluentValidationsOnDotnet.Model.Customer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsOnDotnet.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var customers = await mediator.Send(new GetAllCustomersQuery());
        return Ok(customers);
    }
}
