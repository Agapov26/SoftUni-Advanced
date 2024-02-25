using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (firstName.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (lastName.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (age <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (salary < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age > 30)
            {
                Salary += Salary * percentage / 100;
            }

            else
            {
                Salary += Salary * percentage / 200;
            }
        }
    }
}
