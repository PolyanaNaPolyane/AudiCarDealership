using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class OrderService(IOrderRepository orderRepository, ICarRepository carRepository, AccountContext accountContext) : IOrderService
{
    public Task<IEnumerable<Order>> GetAllByAccountAsync()
    {
        //return orderRepository.GetAllAsync(accountContext.CurrentAccount.Id);
        return orderRepository.GetAllAsync(1);
    }

    public async Task AddAsync(Car car)
    {
        await orderRepository.AddAsync(new Order
        {
            AccountId = accountContext.CurrentAccount.Id,
            CarId = car.Id,
            OverallPrice = car.Price,
            Status = OrderStatus.Pending
        });

        await carRepository.ChangeStatus(car.Id, CarStatus.Sold);
    }
}