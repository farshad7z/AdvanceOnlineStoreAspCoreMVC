using System;
using System.Collections.Generic;

namespace OnlineStore.Core.Entities.Models;

public partial class Rolse
{
    public int RoleId { get; set; }

    public string RoleTitle { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
