namespace DataAccess.Models.Schemas;

public class OrderSchema
{
    public int CustomerId { get; set; }
    public List<ProductCartObject> Items { get; set; } = null!;
    public double TotalAmount { get; set; }
    public double PromotionDiscount { get; set; }
    public AddressSchema? BillingAddressSchema { get; set; }
    public AddressSchema? DeliveryAddressSchema { get; set; }
    public PaymentMethodSchema? PaymentMethod { get; set; }

}
