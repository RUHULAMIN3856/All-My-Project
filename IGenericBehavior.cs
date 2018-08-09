using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_03
{
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior(T obj);
    }
}
