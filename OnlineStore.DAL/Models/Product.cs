using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Title { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string Text { get; set; } = null!;

    public int Price { get; set; }

    public DateTime CreateDate { get; set; }

    public string ImageName { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ProductComment> ProductComments { get; set; } = new List<ProductComment>();

    public virtual ICollection<ProductCount> ProductCounts { get; set; } = new List<ProductCount>();

    public virtual ICollection<ProductFeature> ProductFeatures { get; set; } = new List<ProductFeature>();

    public virtual ICollection<ProductGallery> ProductGalleries { get; set; } = new List<ProductGallery>();

    public virtual ICollection<ProductSelectGroup> ProductSelectGroups { get; set; } = new List<ProductSelectGroup>();

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
}
