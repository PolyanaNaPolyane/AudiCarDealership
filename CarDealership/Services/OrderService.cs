using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class OrderService(IOrderRepository orderRepository, ICarRepository carRepository, AccountContext accountContext)
    : IOrderService
{
    public Task<IEnumerable<Order>> GetAllAsync()
    {
        return orderRepository.GetAllAsync();
    }

    public Task<IEnumerable<Order>> GetAllByAccountAsync()
    {
        return orderRepository.GetAllAsync(accountContext.CurrentAccount.Id);
    }

    public Task<decimal> GetOverallProfitAsync()
    {
        return orderRepository.GetOverallProfitAsync();
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

    public Task UpdateAsync(Order order)
    {
        return orderRepository.UpdateAsync(order);
    }

    public Task DeleteAsync(int id)
    {
        return orderRepository.DeleteAsync(id);
    }
}