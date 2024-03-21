using MediatR;
using SQRC.Mediator.Demo.Data;

namespace SQRC.Mediator.Demo.Queries;

   public record GetProductsQuery():IRequest<IEnumerable<Product>>;

