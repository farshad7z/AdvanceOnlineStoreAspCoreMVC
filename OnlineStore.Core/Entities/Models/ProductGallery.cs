using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class ProductGallery
{
    public int GalleryId { get; set; }

    public int ProductId { get; set; }

    public string Title { get; set; } = null!;

    public string ImageName { get; set; } = null!;

    public string? ColorCode { get; set; }

    public virtual Product Product { get; set; } = null!;
}
