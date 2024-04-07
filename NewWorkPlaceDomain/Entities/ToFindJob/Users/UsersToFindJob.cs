using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Entities.ToFindJob.Users
{
    public class UsersToFindJob
    {
        [Key]
        public Guid Id { get; set; }
        public string EmailUserToFindJob { get; set; } = null!;

    }
}
