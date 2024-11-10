using System;
using System.Collections.Generic;

namespace OnlineStore.Core.Entities.Models;

public partial class Feature
{
    public int FeatureId { get; set; }

    public string FeatureTitle { get; set; } = null!;

    public virtual ICollection<ProductFeature> ProductFeatures { get; set; } = new List<ProductFeature>();
}
