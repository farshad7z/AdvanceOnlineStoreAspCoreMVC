using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public DateTime? Date { get; set; }

    public int StatusId { get; set; }

    public int? CouponId { get; set; }

    public int? ShippingMethodD { get; set; }

    public int? ShippingMethodCost { get; set; }

    public int? TotalPrice { get; set; }

    public int? FinalPrice { get; set; }

    public bool IsFinaly { get; set; }

    public string? OrderDescription { get; set; }

    public string? FullAddress { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ShippingMethod? ShippingMethodDNavigation { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
