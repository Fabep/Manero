using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Models.Schemas;

[BindProperties]
public class AddressSchema
{
    public string StreetAddress { get; set; } = null!;
    public string? Streetnumber { get; set; }
    public string PostalCode { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string City { get; set; } = null!;
    public string? Region { get; set; }
}
