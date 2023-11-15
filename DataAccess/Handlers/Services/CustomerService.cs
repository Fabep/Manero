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

    public async Task<CustomerAddress> CreateCustomerAddressIfNotExisting(CustomerAddressSchema schema)
    {
        var temp = await _customerAddressRepository.GetAsync(x =>
            x.CustomerId == schema.CustomerId &&
            x.StreetAddress == schema.StreetAddress &&
            x.AddressName == schema.AddressName &&
            x.City == schema.Country &&
            x.Country == schema.Country &&
            x.Streetnumber == schema.Streetnumber &&
            x.PostalCode == schema.PostalCode &&
            x.Region == schema.Region);
        if (temp is null)
        {
            var res = await _customerAddressRepository.CreateAsync(schema.ConvertCustomerAddressSchemaToCustomerAddressEntity());

            if (res is Enums.StatusMessage.Success)
                return null!; 
        }
        return null!;
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
