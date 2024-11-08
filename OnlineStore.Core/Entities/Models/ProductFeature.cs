using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class ProductFeature
{
    public int ProductFeatureId { get; set; }

    public int ProductId { get; set; }

    public int FeatureId { get; set; }

    public string? Value { get; set; }

    public virtual Feature Feature { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
