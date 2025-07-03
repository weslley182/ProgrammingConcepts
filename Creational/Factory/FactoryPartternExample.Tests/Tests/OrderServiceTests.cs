using FactoryPartternExample.Tests.Factory;
using FluentAssertions;

namespace FactoryPartternExample.Tests.Tests;

public class OrderServiceTests
{
    [Fact]
    public void GetOrder_WhenValidId_ShouldReturnOrder()
    {
        // Arrange
        var service = ServiceFactory.CreateOrderServiceWithMockedRepository();

        // Act
        var result = service.GetOrder(1);

        // Assert
        result.Should().NotBeNull();
        result.CustomerName.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void GetOrder_WithValidOrder_ShouldReturnOrder()
    {
        // Arrange
        var service = ServiceFactory.WithValidOrder();
        var result = service.GetOrder(1);
        result.Should().NotBeNull();
    }

    [Fact]
    public void GetOrder_WhenNoOrderExists_ShouldReturnNull()
    {
        // Arrange
        var service = ServiceFactory.WithNoOrder();
        var result = service.GetOrder(1);
        result.Should().BeNull();
    }

    [Fact]
    public void GetOrder_WhenRepositoryThrows_ShouldThrow()
    {
        // Arrange
        var service = ServiceFactory.WithRepositoryException();
        Action act = () => service.GetOrder(1);
        act.Should().Throw<Exception>().WithMessage("*Database error*");
    }

    [Fact]
    public void GetOrder_WhenInvalidData_ShouldReturnInvalidOrder()
    {
        // Arrange
        var service = ServiceFactory.WithInvalidOrder();
        var result = service.GetOrder(1);
        result.Id.Should().BeNegative();
        result.CustomerName.Should().BeNullOrEmpty();
    }
}

