using MediatR;
using SQRC.Mediator.Demo.Data;
using SQRC.Mediator.Demo.Queries;

namespace SQRC.Mediator.Demo.Handlers;

    public class GetProductsHandler : IRequestHandler<GetProductsQuery,IEnumerable<Product>>    
    {
    private readonly DataStore _dataStore;

      public GetProductsHandler(DataStore dataStore) => _dataStore = dataStore;

    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken) => await _dataStore.GetAllProducts(); 

}

