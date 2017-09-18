using System;
using System.Collections.Generic;
using System.Linq;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        private static string NameFromEmail(string v)
        {
            string[] nameStringArray = v.Split('@')[0].Split('.');

            return $"{nameStringArray[1]} {nameStringArray[0]}";
        }

    }
}
