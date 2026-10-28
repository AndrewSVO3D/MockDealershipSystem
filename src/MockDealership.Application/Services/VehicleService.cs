using MockDealership.Application.Interfaces;
using MockDealership.Domain.Entities;

namespace MockDealership.Application.Services;

public class VehicleService(IVehicleRepository vehicles)
{
    public Task<List<Vehicle>> GetInventoryAsync() => vehicles.GetAllAsync();

    public Task<Vehicle?> GetVehicleAsync(int id) => vehicles.GetByIdAsync(id);

    public async Task AddVehicleAsync(Vehicle vehicle)
    {
        if (vehicle.Vin.Length != 17)
            throw new ArgumentException("VIN must be 17 characters.", nameof(vehicle));

        await vehicles.AddAsync(vehicle);
    }
}
