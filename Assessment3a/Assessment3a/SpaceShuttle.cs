using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3a
{
    class SpaceShuttle
    {
        public int Fuel { get; set; }
        public List<Crew> Team
        {
            get
            {
                return _team;
            }
            set
            {
                _team = value;
            }
        }

        public SpaceShuttle()
        {
            Fuel = 0;
            var john = new Crew("John", "Captain");
            var diddy = new Crew("Diddy", "Chimp");
            var hannah = new Crew("Hannah", "Navigator");
            _team.Add(john);
            _team.Add(diddy);
            _team.Add(hannah);
        }

        private List<Crew> _team = new List<Crew>();

        public bool Launch()
        {
            bool successfulLaunch;
            if ((Fuel > 5) && (Team.Count == 3))
            {
                successfulLaunch = true;
            }
            else
            {
                successfulLaunch = false;
            }
            return successfulLaunch;
        }
    }
}
