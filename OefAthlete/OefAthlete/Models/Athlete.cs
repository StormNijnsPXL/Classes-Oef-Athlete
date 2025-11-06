using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefAthlete.Models
{
    internal class Athlete
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int runTime;

        public int RunTime
        {
            get { return runTime; }
            set { runTime = value; }
        }


        public Athlete()
        {

        }
        public Athlete(string name, int seconds)
        {
            Name = name;
            RunTime = seconds;
        }

        public override string? ToString()
        {
            return $"Naam: {Name} - Rentijd: {RunTime}s";
        }
    }
}
