using FastEndpointsImplementation.Models.DTO;
using FastEndpointsImplementation.Models.Entities;

namespace FastEndpointsImplementation.Utils;

public static class CustomerMappings
{
    public static CustomerDto ToDto(this Customer entity)
    {
        if (entity == null) return null;

        return new CustomerDto
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            PhoneNumber = entity.PhoneNumber,
            DateOfBirth = entity.DateOfBirth,
            IsActive = entity.IsActive,
            Orders = entity.Orders?.Select(o => o.ToDto()).ToList()
        };
    }

    public static Customer ToEntity(this CreateCustomer dto)
    {
        return new Customer
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            DateOfBirth = dto.DateOfBirth
        };
    }

    public static void MapToEntity(this Customer entity, UpdateCustomer dto)
    {
        entity.FirstName = dto.FirstName;
        entity.LastName = dto.LastName;
        entity.Email = dto.Email;
        entity.PhoneNumber = dto.PhoneNumber;
        entity.DateOfBirth = dto.DateOfBirth;
        entity.IsActive = dto.IsActive;
    }
}