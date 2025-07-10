using MediatR;

namespace FluentValidationsOnDotnet.Model.Customer;

public class GetAllCustomersQueryHandler
    : IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>
{
    private static readonly List<Customer> _customers = new()
    {
        new Customer
        {
            Id = 1,
            Name = "Alice",
            Email = "alice@email.com",
        },
        new Customer
        {
            Id = 2,
            Name = "Bob",
            Email = "bob@email.com",
        },
    };

    public async Task<IEnumerable<Customer>> Handle(
        GetAllCustomersQuery request,
        CancellationToken cancellationToken
    )
    {
        await Task.Delay(50, cancellationToken); // Simulate latency
        return _customers.AsEnumerable();
    }
}
