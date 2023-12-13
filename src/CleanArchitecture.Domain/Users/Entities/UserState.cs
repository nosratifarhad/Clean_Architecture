using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Users.Entities;

public class UserState : BaseEntity
{
    public int UserId { get; set; }

    public bool IsLogin { get; set; }

    public DateTime LoginDate { get; set; }

    public DateTime? LogOutDate { get; set; }

}
