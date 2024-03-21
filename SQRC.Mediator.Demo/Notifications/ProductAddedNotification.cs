using MediatR;
using SQRC.Mediator.Demo.Data;

namespace SQRC.Mediator.Demo.Notifications;

    public record ProductAddedNotification(Product Product) : INotification;
    
    

