using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day16.MyFactory
{
    interface IGameFactoryMine<T, UEnum>
        where UEnum : Enum
    {
        T Create(UEnum type);
    }
}
