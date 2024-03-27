using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.ToTakeJob.Users
{
    public class UsersToTakeJob
    {
        [Key]
        public Guid Id { get; set; }
        public string EmailUsersToTakeJob { get; set; } = null!;
    }
}
