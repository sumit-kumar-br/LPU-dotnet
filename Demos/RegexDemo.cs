using System;
using System.Collections.Generic;
using System.Text;
//Add a Namespace for Regular expression
using System.Text.RegularExpressions;

namespace Day_4Demo
{
    class RegexDemo
    {
        public void ValidateData(string data)
        {
            //Regex rObj = new Regex("[a-d]$");
            // Regex rObj = new Regex("[7-9][0-9]{9}");//Phone no validation

            // Regex rObj = new Regex("[^0-9]");// Not accept any number

            // Regex rObj = new Regex("[0-9]{4}[-][0-9]{4}[-][0-9]{4}[-][0-9]{4}");//Credit Card Validation

            //Regex rObj = new Regex(".OP");

            //MH12-AB-1234
            //  Regex rObj = new Regex("[A-W]{2}[0-9]{2}[-][A-Z]{2}[-][0-9]{4}");//for Vehicle No
            //if (data.Length >= 4 && data.Length <= 8)
            //{

            MatchCollection myMatches = Regex.Matches(data, "[A-Z][a-z]+");

                Regex rObj = new Regex("^[a-zA-Z]+$");
                if (rObj.IsMatch(data))
                {
                    Console.WriteLine("Data Accepted");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            //}
            //else
            //{
            //    Console.WriteLine("Max Length reaches");
            //}

        }
    }
}
