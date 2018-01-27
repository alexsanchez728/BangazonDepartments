using System;
using System.Collections.Generic;
using BangazonDepartments.Departments;

namespace BangazonDepartments
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseBudget = 75000.00;

            var myHR = new HumanResources("Inhuman Resources", "3rd", 100, "4 year");
            myHR.AddPolicy("Lorem Ipsum Policy", "Leverage agile frameworks to provide a robust synopsis for high level overviews. Iterative approaches to corporate strategy foster collaborative thinking to further the overall value proposition.");

            var myQA = new QualityAssurance("Key-Bashers", "4th", 10, "36 month");
            myQA.AddProductToTest("Happy AI", "Is angsty, listening to Emmure all the time, and refusing to believe in, quote: 'your imposed fallacy of happiness' end quote.");

            var myFrontEnd = new FrontEndDevs("Code Monkeys", "basement", 5, "2 year");
            myFrontEnd.AddNewFramework("fooVue", "SUCH a cool new framework. It does it all and then some! Oh I built it myself, obviously, since no other framework does what I NEED.");

            var myCompany = new List<Department>
            {
                myHR, myQA, myFrontEnd
            };

            foreach (Department d in myCompany)
            {
                Console.WriteLine(d.SetBudget(baseBudget));
            }

            Console.WriteLine($"myCompary is comprised of {myCompany.Count} departments");

            Console.ReadKey();
        }
    }
}
