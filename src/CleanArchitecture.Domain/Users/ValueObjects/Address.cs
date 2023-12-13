using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Users.ValueObjects;

public class Address : ValueObject
{
    public string City { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
}