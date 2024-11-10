using System;
using System.Collections.Generic;

namespace OnlineStore.Core.Entities.Models;

public partial class AddressesUser
{
    public int AddressId { get; set; }

    public int? UserId { get; set; }

    public string Province { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Avenue { get; set; } = null!;

    public string Alley { get; set; } = null!;

    public int Plaque { get; set; }

    public int Unit { get; set; }

    public string Code { get; set; } = null!;

    public bool IsDelete { get; set; }

    public bool IsUserAddress { get; set; }

    public virtual User? User { get; set; }
}
