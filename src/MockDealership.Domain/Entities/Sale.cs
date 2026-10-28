namespace MockDealership.Domain.Entities;

public class Sale
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public int CustomerId { get; set; }
    public decimal SalePrice { get; set; }
    public DateTime SoldAt { get; set; }

    public Vehicle Vehicle { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
}
