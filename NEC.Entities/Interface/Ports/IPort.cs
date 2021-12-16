using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Entities.Interface.Ports
{
    public interface IPort<T>
    {
        ValueTask Handle(T dto);
    }

    public interface IPort
    {
        ValueTask Handle();
    }

}
