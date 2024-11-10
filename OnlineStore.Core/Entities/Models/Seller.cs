using System;
using System.Collections.Generic;

namespace OnlineStore.Core.Entities.Models;

public partial class Seller
{
    public int SellerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string NationalId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
