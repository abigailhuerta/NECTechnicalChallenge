using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Entities.Interface
{
    public interface IApplicationStatusLogger
    {
        void Log(string message);
    }
}
