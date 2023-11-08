using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace ValidacionEmail
{
    public class ValidacionEmail
    {
        public static void Main(string[] args)
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
        }

        private static bool IsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }
    }
}