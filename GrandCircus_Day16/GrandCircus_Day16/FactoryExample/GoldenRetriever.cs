using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day16.FactoryExample
{
    class GoldenRetriever : IDog
    {
        public string Bark()
        {
            return "Happy woof woof!";
        }
    }
}
