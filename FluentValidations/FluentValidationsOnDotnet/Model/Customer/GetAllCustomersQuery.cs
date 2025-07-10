using MediatR;

namespace FluentValidationsOnDotnet.Model.Customer;

public record GetAllCustomersQuery() : IRequest<IEnumerable<Customer>>;
