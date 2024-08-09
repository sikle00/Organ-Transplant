using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Organ_Transplant
{
    internal class Persons
    {
        public string IntactOrgans;
        public string NeededOrgans;
        public string Name;
        public bool Alive;
        public Persons(string name, string damagedOrgans, string intactOrgans, bool alive)
        {
            IntactOrgans = intactOrgans;
            NeededOrgans = damagedOrgans;
            Name = name;
            Alive = alive;
            Alive = true;
    }
    }
}
