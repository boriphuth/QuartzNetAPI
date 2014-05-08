﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.API.Contracts
{
    public interface ILoggingProvider
    {
        IEnumerable<string> GetLogs();
    }
}
