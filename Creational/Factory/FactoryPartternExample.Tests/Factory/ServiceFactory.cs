using Bogus;
using FactoryPartternExample.Tests.Domain;
using FactoryPartternExample.Tests.Interfaces;
using FactoryPartternExample.Tests.Service;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace FactoryPartternExample.Tests.Factory;

public static class ServiceFactory
{
    public static OrderService CreateOrderServiceWithMockedRepository()
    {
        var repository = Substitute.For<IOrderRepository>();

        var faker = new Faker<Order>()
            .RuleFor(x => x.Id, f => f.Random.Int(1, 1000))
            .RuleFor(x => x.CustomerName, f => f.Person.FullName);

        var fakeOrder = faker.Generate();

        repository.GetById(Arg.Any<int>()).Returns(fakeOrder);

        return new OrderService(repository);
    }

    public static OrderService WithValidOrder()
    {
        var repo = Substitute.For<IOrderRepository>();
        var order = new Faker<Order>()
            .RuleFor(x => x.Id, 1)
            .RuleFor(x => x.CustomerName, f => f.Person.FullName)
            .Generate();

        repo.GetById(Arg.Any<int>()).Returns(order);
        return new OrderService(repo);
    }

    public static OrderService WithNoOrder()
    {
        var repo = Substitute.For<IOrderRepository>();
        repo.GetById(Arg.Any<int>()).Returns((Order?)null);
        return new OrderService(repo);
    }

    public static OrderService WithRepositoryException()
    {
        var repo = Substitute.For<IOrderRepository>();
        repo.GetById(Arg.Any<int>()).Throws(new Exception("Database error"));
        return new OrderService(repo);
    }

    public static OrderService WithInvalidOrder()
    {
        var repo = Substitute.For<IOrderRepository>();
        var order = new Order { Id = -1, CustomerName = string.Empty };
        repo.GetById(Arg.Any<int>()).Returns(order);
        return new OrderService(repo);
    }
}

