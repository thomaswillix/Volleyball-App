using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace  Practica1
{
    public class ValidacionEmail
    {
        //Ejemplo de validación sencillito.

        /*public static void Main(string[] args)
        {
            var emailAddresses = new List<string>
            {
                // Valid email addresses
                "tony@example.com",
                "tony.stark@example.net",
                "tony@example.co.uk",
                "tony@example",

                // Invalid email addresses
                "tony.example.com",
                "tony@stark@example.net",
                "tony@.example.co.uk"
            };

            Console.Title = "Email address validation";

            foreach (var emailAddress in emailAddresses)
                Console.WriteLine($"{emailAddress,-37} --> {(IsValid(emailAddress) ? "Valid" : "Invalid")}");

            Console.ReadLine();
        }*/

        public static bool IsValid(string email)
        {
            var valid = true;
            
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch (FormatException)
            {
                valid = false;
            }
            catch (ArgumentException)
            {
                valid = false;
            }

            return valid;
        }
    }
}