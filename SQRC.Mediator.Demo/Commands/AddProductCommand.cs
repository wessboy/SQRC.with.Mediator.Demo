using MediatR;
using SQRC.Mediator.Demo.Data;

namespace SQRC.Mediator.Demo.Commands;

public record AddProductCommand(Product Product) : IRequest<Product>;

  

