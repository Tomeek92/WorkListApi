using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Entities.ToFindJob.Register
{
    public class RegisterToFindJob
    {
        [Key]
        public Guid Id { get; set; } 
        public string RegisterEmailToFindJob { get; set; } = null!;
        public string RegisterPasswordToFindJob { get; set; } = null!;
        public DateTime RegisterTimeToFindJob { get; set; } = DateTime.UtcNow;

    }
}
