using System;
using System.Collections.Generic;

namespace OnlineStore.DAL.Entities.Models;

public partial class Rolse
{
    public int RoleId { get; set; }

    public string RileTitle { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
