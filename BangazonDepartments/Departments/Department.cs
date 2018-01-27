using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    abstract class Department
    {
        private string _name;
        private string _floor;
        private int _employee_count;
        private string _contractLength;

        public Department(string name, string floor, int employees, string contractLength)
        {
            _name = name;
            _floor = floor;
            _employee_count = employees;
            _contractLength = contractLength;
        }
        public void MeetForLunch(string lunchSpot)
        {
            Console.WriteLine($"We're going to eat at the {lunchSpot}");
        }

        public abstract double SetBudget(double budget);
    }
}
