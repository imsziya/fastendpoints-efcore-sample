using FastEndpoints;
using FastEndpointsImplementation.Models.DTO;
using FastEndpointsImplementation.Models.Entities;
using FastEndpointsImplementation.Utils;

namespace FastEndpointsImplementation.Endpoints;

public class CreateCustomerEndpoint(AppDbContext db) : Endpoint<CreateCustomer, CustomerDto>
{
    public override void Configure()
    {
        Post("/customers");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateCustomer req, CancellationToken ct)
    {
        var entity = db.Customers.Add(req.ToEntity());
        await db.SaveChangesAsync(ct);
        var res = entity.Entity.ToDto();
        await Send.OkAsync(res, ct);
    }
}
