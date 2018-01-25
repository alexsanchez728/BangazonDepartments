using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    class FrontEndDevs : Department
    {
        private Dictionary<string, string> _newFramework = new Dictionary<string, string>();
        private double Budget;

        public FrontEndDevs(string dept_name, string floor, int employees) : base(dept_name, floor, employees)
        {
        }
        public void AddNewFramework(string framework, string howCool)
        {
            _newFramework.Add(framework, howCool);

            foreach (KeyValuePair<string, string> coolThing in _newFramework)
            {
                Console.WriteLine($"We want to try {framework} on this project. It's {howCool}");
            }
        }

        public void MeetForLunch(string lunchSpot, bool broughtAlc, int numberOfAlcohols)
        {
            if (broughtAlc)
            {
                Console.WriteLine($"The front end devs brought {numberOfAlcohols} craft brews per person. Yieks.");
            }
            Console.WriteLine($"We're going to eat at the {lunchSpot}, totally sober");
        }
        public override double SetBudget(double budget) => this.Budget += budget + 100000.00;
    }
}
