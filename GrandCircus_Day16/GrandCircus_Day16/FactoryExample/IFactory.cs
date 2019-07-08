using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day16.FactoryExample
{
    interface IFactory<T, UEnum>
        where UEnum: Enum
    {
        T Create(UEnum type);
    }
}
