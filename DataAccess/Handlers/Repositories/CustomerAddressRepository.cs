using DataAccess.Contexts;
using DataAccess.Models.Entities;

namespace DataAccess.Handlers.Repositories;

public class CustomerAddressRepository : Repository<CustomerAddressEntity, LocalContext>
{
    public CustomerAddressRepository(LocalContext context) : base(context)
    {
    }
}
