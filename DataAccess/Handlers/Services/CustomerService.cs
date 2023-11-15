using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Schemas;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Handlers.Services;

public class CustomerService : ICustomerService
{
    private readonly CustomerAddressRepository _customerAddressRepository;
    public CustomerService(CustomerAddressRepository customerAddressRepository)
    {
        _customerAddressRepository = customerAddressRepository;
    }

    public async Task<List<CustomerAddress>> GetAllCustomerAddressesFromCustomerId(int id)
    {
        return await _customerAddressRepository.GetAll(x => x.CustomerId == id).Select(x => new CustomerAddress
        {
            StreetAddress = x.StreetAddress,
            City = x.City,
            PostalCode = x.PostalCode,
            Country = x.Country,
            Streetnumber = x.Streetnumber,
            AddressName = x.AddressName,
            Region = x.Region,
        }).ToListAsync();
    }
}
