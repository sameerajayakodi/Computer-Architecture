﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuFactory
{
    public abstract class Company
    {
        public abstract Monitor CreateMonitor();
        public abstract Gpu CreateGpu();
    }
}
