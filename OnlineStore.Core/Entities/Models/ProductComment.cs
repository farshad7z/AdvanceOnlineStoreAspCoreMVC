using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Models;

public partial class ProductComment
{
    public int CommentId { get; set; }

    public int ProductId { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public bool AdminConfirmation { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public int? ParentId { get; set; }

    public virtual ICollection<ProductComment> InverseParent { get; set; } = new List<ProductComment>();

    public virtual ProductComment? Parent { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User? User { get; set; }
}
