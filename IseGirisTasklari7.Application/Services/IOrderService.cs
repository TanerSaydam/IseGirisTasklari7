using IseGirisTasklari7.Application.Features.Orders.Commands.CreateOrderCommand;

namespace IseGirisTasklari7.Application.Services;

public interface IOrderService
{
    Task CreateOrder(CreateOrderCommand request);
}
