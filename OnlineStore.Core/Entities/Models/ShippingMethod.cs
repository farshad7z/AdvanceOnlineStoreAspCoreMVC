﻿using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class ShippingMethod
{
    public int ShippingMethodId { get; set; }

    public string Name { get; set; } = null!;

    public int Cost { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
