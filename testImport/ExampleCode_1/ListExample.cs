using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCode_1
{
    class ListExample
    {
        public ListExample() { }

        public void ListOperations()
        {
            var listObj = new List<string>
            {
                // Collections can be initialized with values
                "Ajeet",
                "Harry",
                "Chaitanya",
                "Steve"
            };

            listObj.Add("Anuj"); // Adds "Anuj" to the list

            listObj.Remove("Chaitanya"); //Removes "Chaitanya" from List
            listObj.Remove("Harry"); //Removes "Harry" from List
            
            listObj.RemoveAt(1); 
        }
    }
}
