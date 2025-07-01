using FactoryPartternExample.Tests.Domain;
using FactoryPartternExample.Tests.Interfaces;

namespace FactoryPartternExample.Tests.Service;

public class OrderService
{
    private readonly IOrderRepository _repository;

    public OrderService(IOrderRepository repository)
    {
        _repository = repository;
    }

    public Order GetOrder(int id)
    {
        return _repository.GetById(id);
    }
}

