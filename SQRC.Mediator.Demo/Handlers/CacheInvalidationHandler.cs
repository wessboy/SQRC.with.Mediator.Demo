using MediatR;
using SQRC.Mediator.Demo.Data;
using SQRC.Mediator.Demo.Notifications;

namespace SQRC.Mediator.Demo.Handlers
{
    public class CacheInvalidationHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly DataStore _dataStore;
        public CacheInvalidationHandler(DataStore dataStore) =>  _dataStore = dataStore;
        
        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _dataStore.EventOccured(notification.Product, "CacheInvalidated");
            await Task.CompletedTask;
        }
    }
}
