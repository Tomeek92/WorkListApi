using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.IdentityUsers
{
    public class UsersIdentity /*IdentityUser*/
    {
        [Key]
        public Guid Id { get; set; }
        public string EmailIdentity { get; set; } = null!;
    }
}
