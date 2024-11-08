using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class User
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string ActiveCode { get; set; } = null!;

    public DateTime RegisterDate { get; set; }

    public string? PhoneNumber { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<AddressesUser> AddressesUsers { get; set; } = new List<AddressesUser>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<ProductComment> ProductComments { get; set; } = new List<ProductComment>();

    public virtual Rolse Role { get; set; } = null!;
}
