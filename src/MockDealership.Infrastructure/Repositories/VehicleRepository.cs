using Microsoft.EntityFrameworkCore;
using MockDealership.Application.Interfaces;
using MockDealership.Domain.Entities;
using MockDealership.Infrastructure.Data;

namespace MockDealership.Infrastructure.Repositories;

public class VehicleRepository(AppDbContext db) : IVehicleRepository
{
    public Task<List<Vehicle>> GetAllAsync() =>
        db.Vehicles.AsNoTracking().OrderBy(v => v.Make).ThenBy(v => v.Model).ToListAsync();

    public Task<Vehicle?> GetByIdAsync(int id) =>
        db.Vehicles.AsNoTracking().FirstOrDefaultAsync(v => v.Id == id);

    public async Task AddAsync(Vehicle vehicle)
    {
        db.Vehicles.Add(vehicle);
        await db.SaveChangesAsync();
    }
}
