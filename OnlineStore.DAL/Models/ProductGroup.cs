using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Models;

public partial class ProductGroup
{
    public int GroupId { get; set; }

    public string GroupTitle { get; set; } = null!;

    public int? ParentId { get; set; }

    public virtual ICollection<ProductGroup> InverseParent { get; set; } = new List<ProductGroup>();

    public virtual ProductGroup? Parent { get; set; }

    public virtual ICollection<ProductSelectGroup> ProductSelectGroups { get; set; } = new List<ProductSelectGroup>();
}
