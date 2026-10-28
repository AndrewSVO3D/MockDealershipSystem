namespace MockDealership.Domain.Entities;

public class Vehicle
{
    public int Id { get; set; }
    public string Vin { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public int Mileage { get; set; }
    public decimal Price { get; set; }
    public VehicleStatus Status { get; set; } = VehicleStatus.Available;

    public Sale? Sale { get; set; }

    public Vehicle()
    {
    }

    public Vehicle(int id, int year, int mileage, decimal price)
    {
        Id = id;
        Year = year;
        Mileage = mileage;
        Price = price;
    }
}
