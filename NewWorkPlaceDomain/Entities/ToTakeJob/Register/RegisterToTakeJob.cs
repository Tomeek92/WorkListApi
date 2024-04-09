using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Entities.ToTakeJob.Register
{
    public class RegisterToTakeJob
    {
        public Guid Id { get; set; }  
        public string RegisterEmailToTakeJob { get; set; } = null!;
        public string RegisterPasswordToTakeJob { get; set; } = null!;
        public int RegisterPhoneNumberToTakeJob { get;set; }
        public string RegisterNameToTakeJob { get; set; } = null!;
        public string RegisterAddressToTakeJob { get; set; } = null!;
        public DateTime RegisterTimeToTakeJob { get; set; } = DateTime.UtcNow;
    }
}
