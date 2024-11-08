using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class ProductSelectGroup
{
    public int PgId { get; set; }

    public int ProductId { get; set; }

    public int ProductGroupId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual ProductGroup ProductGroup { get; set; } = null!;
}
