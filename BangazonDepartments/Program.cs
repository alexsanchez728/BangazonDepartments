using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BangazonDepartments.Departments;

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

            var myFrontEnd = new FrontEndDevs("Code Monkeys", "basement", 5);
            myFrontEnd.AddNewFramework("fooVue", "SUCH a cool new framework. It does it all and then some! Oh I built it myself, obviously, since no other framework does what I NEED.");

            var myCompany = new List<Department>
            {
                myHR, myQA, myFrontEnd
            };

            Console.WriteLine($"myCompary is comprised of {myCompany.Count} departments");

            Console.WriteLine($"");

            Console.ReadKey();
        }
    }
}
