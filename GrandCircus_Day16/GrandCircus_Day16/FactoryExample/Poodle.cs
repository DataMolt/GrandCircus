using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day16.FactoryExample
{
    class Poodle : DogBase, IDog
    {
        public string Bark()
        {
            return "Fancy Bark!";
        }
    }
}
