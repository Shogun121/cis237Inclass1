﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Person
    {
        string firstName;
        string lastName;
        int age;


        //Deafault Constructor
        public Person()
        {

        }
        //3 Parameter Constructor
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void PrintFullName()
        {
            Console.WriteLine(this.firstName +' '+ this.lastName);
        }
        //First Name Property
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName=value;
            }

        }
        //Last Name Property
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
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
                this.age = value;
            }

        }
    }
}
