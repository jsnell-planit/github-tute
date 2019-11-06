using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCode_1
{
    /*
     * Write a description of the class here
     * 
     * Author:  (your name)
     * Version: (version number or date)
     */
    public class GenericClassExample
    {
        // TODO: ATTRIBUTES
        private string goJoust = "Go Joust!";
        private int myInt = 012345;
        public string goJoust1 = "H";
        public bool myBoolProp { get; set; }

        // TODO: CONSTRUCTOR

        // TODO: METHODS
        public static string generateFullName(string firstName, string lastName)
        {
            //example longhand 
            string foreName = "Luke";
            string surname = "Skywalker";

            string fullName = foreName + surname;
            Console.WriteLine("Full name: ", fullName)

            //end example
            
            return firstName + " " + lastName;
        }
    }
}
