using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3a
{
    class Crew
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Crew(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
