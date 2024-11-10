using System;
using System.Collections.Generic;

namespace OnlineStore.Core.Entities.Models;

public partial class Store
{
    public int StoreId { get; set; }

    public string StoreName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int? SellerId { get; set; }

    public bool? IsActive { get; set; }

    public double? Rating { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual Seller? Seller { get; set; }
}
