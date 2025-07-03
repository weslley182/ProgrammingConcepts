using FactoryPartternExample.Tests.Domain;

namespace FactoryPartternExample.Tests.Interfaces;

public interface IOrderRepository
{
    Order GetById(int id);
}
