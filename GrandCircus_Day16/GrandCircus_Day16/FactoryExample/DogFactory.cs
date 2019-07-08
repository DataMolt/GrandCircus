using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day16.FactoryExample
{
    class DogFactory : IFactory<IDog, DogType>
    {
        public IDog Create(DogType type)
        {
            switch (type)
            {
                case DogType.Poodle: return new Poodle();

                case DogType.GoldenRetriever: return new GoldenRetriever();

                case DogType.Pitbull: return new Pitbull();

                case DogType.Dalmation: return new Dalmation();

                default: throw new ArgumentOutOfRangeException("Invalid");
            }
        }
    }
}
