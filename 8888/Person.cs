using System;

namespace Person
{
    class Person
    {
        string firstName;
        string lastName;

        public static string salutationMr = "Mr";
        public static string salutationMs = "Ms";

        string getName()
        {
            return firstName + " " + lastName;
        }

        public Person()
        {
            firstName = "John";
            lastName = "Doe";
        }

        public Person(string lname) // Why is this here?
        {
            lastName = lname;
        }
    }

    class Wife : Person
    {
        public string salutationMrs = "Mrs";
        public string husbandFN;
        public string husbandLN;
        public string marriagedate;

        string getHusbandsName()
        {
            return husbandFN + " " + husbandLN;
        }

        public Wife()
        {
            husbandFN = "John";
            husbandLN = "LN";
            marriagedate = "July 8";
        }
    }
}
