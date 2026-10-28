namespace MockDealership.Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }

    public List<Sale> Purchases { get; set; } = new();
    
    public Customer()
    {
    }

    public Customer(int id, string firstName, string lastName, string email, string? phone = null, List<Sale>? purchases = null)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Purchases = purchases ?? new();
    }
}
