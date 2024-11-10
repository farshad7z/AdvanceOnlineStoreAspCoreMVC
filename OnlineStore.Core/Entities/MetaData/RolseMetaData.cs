using OnlineStore.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Entities.MetaData
{
    public partial class RolseMetaData
    {
        [Key]
        public int RoleId { get; set; }

        [Display(Name ="عنوان نقش")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string RoleTitle { get; set; } = null!;

        [Display(Name = "عنوان سیستمی نقش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string RoleName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; } = new List<User>();

    }
    [MetadataType(typeof(RolseMetaData))]
    public partial class Rolse
    {

    }

}
