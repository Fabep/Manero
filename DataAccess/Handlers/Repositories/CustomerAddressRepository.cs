using DataAccess.Contexts;
using DataAccess.Models.Entities;
using DataAccess.Models.Schemas;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Handlers.Repositories;

public class CustomerAddressRepository : Repository<CustomerAddressEntity, LocalContext>
{
    public CustomerAddressRepository(LocalContext context) : base(context)
    {
    }
}
