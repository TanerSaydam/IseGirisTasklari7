﻿using IseGirisTasklari7.Application.Features.Orders.Commands.CreateOrderCommand;
using IseGirisTasklari7.Application.Services;
using IseGirisTasklari7.Domain;
using IseGirisTasklari7.Domain.Entities;
using IseGirisTasklari7.Domain.Repositories.OrderRepositories;

namespace IseGirisTasklari7.Persistance.Services;

public sealed class OrderService : IOrderService
{
    private readonly IOrderCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IOrderCommandRepository commandRepository, IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateOrder(CreateOrderCommand request)
    {
        Order order = new()
        {
            Id = Guid.NewGuid().ToString(),
            CreatedDate = DateTime.Now,
            CustomerName = request.CustomerName,
            FirmaId = request.FirmaId,
            OrderDate = DateTime.Now,
            ProductId = request.ProductId,
        };
        await _commandRepository.AddAsync(order);
        await _unitOfWork.SaveChangesAsync();
    }
}
