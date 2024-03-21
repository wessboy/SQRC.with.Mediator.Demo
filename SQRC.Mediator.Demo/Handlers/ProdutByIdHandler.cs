using MediatR;
using SQRC.Mediator.Demo.Data;
using SQRC.Mediator.Demo.Queries;

namespace SQRC.Mediator.Demo.Handlers;

public class ProdutByIdHandler : IRequestHandler<GetProductByIdQuery,Product>
{
    private readonly DataStore _dataStore;
    public ProdutByIdHandler(DataStore dataStore) => _dataStore = dataStore;

    

    public async Task<Product> Handle(GetProductByIdQuery request,CancellationToken cancellationToken) =>
    
        await _dataStore.GetProductById(request.Id);
    
}

