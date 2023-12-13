using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Users.Enums;
using CleanArchitecture.Domain.Users.ValueObjects;

namespace CleanArchitecture.Domain.Users.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Address Address { get; set; }
    public Gender Gender { get; set; }
}