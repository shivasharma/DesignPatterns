using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    internal interface ILog
    {
        void LogException(string message);
    }
}