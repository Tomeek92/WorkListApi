﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceDomain.Entities.ToFindJob.Login
{
    public class LoginToFindJob
    {
        public string LoginEmailToFindJob { get; set; } = null!;
        public string LoginPasswordToFindJob { get; set; } = null!;
        public DateTime LoginAt { get; set; } = DateTime.UtcNow;
    }
}
