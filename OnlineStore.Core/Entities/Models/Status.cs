using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class Status
{
    public int StatusId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
