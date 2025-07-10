using FluentValidation;
using FluentValidationsOnDotnet.Extensions;
using FluentValidationsOnDotnet.Model.Customer;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsOnDotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController(IValidator<Customer> validator) : ControllerBase
{
    private readonly IValidator<Customer> _validator = validator;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Customer customer)
    {
        var result = await _validator.ValidateAsync(customer);

        if (!result.IsValid)
            return BadRequest(result.Errors.ToGroupedValidationErrors());

        return Ok(customer);
    }
}
