﻿using BangazonDepartments.Employment;
using BangazonDepartments.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    class QualityAssurance : Department, IPartTime, IAtEastside, IEmploymentLength
    {
        private Dictionary<string, string> _bugReports = new Dictionary<string, string>();
        private double Budget;
        private double _houryRate;
        private bool _keyCardAccess;
        private string _contractLength;

        public QualityAssurance(string dept_name, string floor, int employees, string contractLength) : base(dept_name, floor, employees, contractLength)
        {
        }

        public double HourlyRate
        {
            get => _houryRate;
            set
            {
                if (value >= 20 && value <= 35)
                {
                    _houryRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Cannot set hourly rate to specified value.");
                }
            }
        }

        public bool KeycardAccess => _keyCardAccess;

        public string ContractLength => _contractLength;


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
        public override double SetBudget(double budget) => this.Budget += budget + 1000.00;
    }
}
