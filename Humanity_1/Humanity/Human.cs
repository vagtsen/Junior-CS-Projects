using System;
using System.Text;

namespace Humanity
{
   
    class Human
    {
         
        private const int FirstNameMinLength = 4;
        private const int LastNameMinLength = 3;

        private string firstName;
        private string lastName;

      
        
        private string FirstName
        {
            set
            {
                
                if (value.Length < FirstNameMinLength)
                {
                    throw new ArgumentException($"Expected length at least {FirstNameMinLength} symbols! Argument: {firstName}");
                }
                firstName = char.ToUpper(value[0]) + value.Substring(1);             
            }
        } 

        private string LastName 
        {
            set
            {
                if (value.Length < LastNameMinLength)
                {
                    throw new ArgumentException($"Expected length at least {LastNameMinLength} symbols! Argument: {lastName}");
                }
                lastName = char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        
        //Human Constructor
        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        //Overriding ToString for printing the results 
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {firstName}")
                .AppendLine($"Last Name: {lastName}");

            return sb.ToString();
        }
       
    }
}

