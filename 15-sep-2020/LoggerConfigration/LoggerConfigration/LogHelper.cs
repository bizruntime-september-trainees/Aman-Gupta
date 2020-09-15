﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace LoggerConfigration
{
    class LogHelper
    {
        public static log4net.ILog GetLog([CallerFilePath]string filename="")
        {
            return log4net.LogManager.GetLogger(filename);
        }
    }
}
