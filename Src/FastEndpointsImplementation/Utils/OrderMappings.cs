using FastEndpointsImplementation.Models.DTO;
using FastEndpointsImplementation.Models.Entities;

namespace FastEndpointsImplementation.Utils;

public static class OrderMappings
{
    public static OrderDto ToDto(this Order entity)
    {
        if (entity == null) return null;

        return new OrderDto
        {
            Id = entity.Id,
            OrderDate = entity.OrderDate,
            TotalAmount = entity.TotalAmount,
            CustomerId = entity.CustomerId
        };
    }

    public static Order ToEntity(this CreateOrder dto)
    {
        return new Order
        {
            TotalAmount = dto.TotalAmount,
            CustomerId = dto.CustomerId
        };
    }
}