using System;
using System.Collections.Generic;

namespace OnlineStore.Core.Entities.Models;

public partial class ProductTag
{
    public int TagId { get; set; }

    public int ProductId { get; set; }

    public string Tag { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
