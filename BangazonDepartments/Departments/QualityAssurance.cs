using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    class QualityAssurance : Department
    {
        private Dictionary<string, string> _bugReports = new Dictionary<string, string>();

        public QualityAssurance(string dept_name, string floor, int employees) : base(dept_name, floor, employees)
        {
        }
        public void AddProductToTest(string product, string bug)
        {
            _bugReports.Add(product, bug);

            foreach (KeyValuePair<string, string> report in _bugReports)
            {
                Console.WriteLine($"Welcome to QA, as of now our {product} has a bug that has been described as follows: {bug}");
            }
        }

        public void MeetForLunch(string lunchSpot, bool eatsAlone)
        {
            if (eatsAlone)
            {
                Console.WriteLine($"QA was testing everybody's food too saying 'its part of the job!' so now they don't get to eat at {lunchSpot}");
            }
            if (!eatsAlone)
            {
            Console.WriteLine($"We're going to eat at the {lunchSpot}, gotta do QA on their food.");
            }
        }
    }
}
