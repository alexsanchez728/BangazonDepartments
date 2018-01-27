using BangazonDepartments.Employment;
using BangazonDepartments.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    class HumanResources : Department, IFullTime, IAtWestside, IEmploymentLength
    {
        Dictionary<string, string> _policies = new Dictionary<string, string>();
        double Budget;
        double _salary;
        bool _keyCardAccess;
        string _contractLength;

        public HumanResources(string dept_name, string floor, int employees, string contractLength) : base(dept_name, floor, employees, contractLength)
        {
        }

        public double Salary
        {
            get => _salary;
            set
            {
                if (value >= 40000 && value <= 55000)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Cannot set salary to value specified");
                }
            }
        }

        public bool KeycardAccess => _keyCardAccess;

        public string ContractLength => _contractLength;

        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"Welcome to our Human Resources department. Here one of our values is: {policy.Value}");
            }
        }

        public void MeetForLunch(string lunchSpot, bool broughtAlc)
        {
            if (broughtAlc)
            {
                Console.WriteLine($"The whole Human Resources department had a rough day and brought booze from home.");
            }
            Console.WriteLine($"We're going to eat at the {lunchSpot}, totally sober");
        }
        public override double SetBudget(double budget) => this.Budget -= budget - 1000.00;
    }
}
