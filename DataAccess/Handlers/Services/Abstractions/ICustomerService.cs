using DataAccess.Models;
using DataAccess.Models.Schemas;

namespace DataAccess.Handlers.Services.Abstractions;

public interface ICustomerService
{
    Task<List<CustomerAddress>> GetAllCustomerAddressesFromCustomerId(int id);
}
