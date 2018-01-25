using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHR = new HumanResources("Inhuman Resources", "3rd", 100);
            myHR.AddPolicy("Lorem Ipsum Policy", "Leverage agile frameworks to provide a robust synopsis for high level overviews. Iterative approaches to corporate strategy foster collaborative thinking to further the overall value proposition.");

            var myQA = new QualityAssurance("Key-Bashers", "4th", 10);
            myQA.AddProductToTest("Happy AI", "Is angsty, listening to Emmure all the time, and refusing to believe in, quote: 'your imposed fallacy of happiness' end quote.");

            var myFrontEnd = new FrontEndDevelopers("Code Monkeys", "basement", 5);
            myFrontEnd.AddNewFramework("fooVue", "SUCH a cool new framework. It does it all and then some! Oh I built it myself, obviously, since no other framework does what I NEED.");

            var myCompany = new List<Department>
            {
                myHR, myQA, myFrontEnd
            };

            Console.WriteLine($"myCompary is comprised of {myCompany.Count} departments");

            Console.ReadKey();
        }

        // 1 EXAMPLE CLASS
        public class Department
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
        }
   
        // 1 EXAMPLE DERIVED CLASS
        public class HumanResources : Department
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
        }

        public class QualityAssurance : Department
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
        }

        public class FrontEndDevelopers : Department
        {
            private Dictionary<string, string> _newFramework = new Dictionary<string, string>();

            public FrontEndDevelopers(string dept_name, string floor, int employees) : base(dept_name, floor, employees)
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
        }
    }
}
