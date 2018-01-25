using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    class HumanResources : Department
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public HumanResources(string dept_name, string floor, int employees) : base(dept_name, floor, employees)
        {
        }

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
    }
}
