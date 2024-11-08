using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class ProductCount
{
    public int ProductCountId { get; set; }

    public int ProductId { get; set; }

    public int PuductFeatureId { get; set; }

    public int? Value { get; set; }

    public virtual Product Product { get; set; } = null!;
}
