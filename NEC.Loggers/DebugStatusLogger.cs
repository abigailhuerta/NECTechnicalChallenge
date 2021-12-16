using NEC.Entities.Interface;
using System;
using System.Diagnostics;

namespace NEC.Crypto.Loggers
{
    public class DebugStatusLogger : IApplicationStatusLogger
    {
        public void Log(string message)
        {
            Debug.WriteLine($"mensaje : {message}");
        }
    }
}
