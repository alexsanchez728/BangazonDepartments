using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    // 1 EXAMPLE CLASS
    abstract class Department
    {
        private string _name;
        private string _floor;
        private int _employee_count;

        public Department(string name, string floor, int employees)
        {
            _name = name;
            _floor = floor;
            _employee_count = employees;
        }
        public void MeetForLunch(string lunchSpot)
        {
            Console.WriteLine($"We're going to eat at the {lunchSpot}");
        }

    }
}
