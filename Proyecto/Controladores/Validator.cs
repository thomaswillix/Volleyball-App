using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proyecto.Controladores
{
    public class Validator
    {
        public static bool validateNumUpDown(NumericUpDown num)
        {

            if (num.Value <= 0)
            {
                num.BackColor = Color.Red;
                return false;
            }
            num.BackColor = Color.White;
            return true;
        }
        public static bool validateDates(DateTimePicker fechaIni, DateTimePicker fechaFin)
        {
            if (fechaIni.Value > fechaFin.Value)
            {
                fechaIni.CalendarTitleBackColor = Color.Red;
                fechaFin.CalendarTitleBackColor = Color.Red;
                return false;
            }
            fechaIni.CalendarTitleBackColor = Color.White;
            fechaFin.CalendarTitleBackColor = Color.White;
            return true;
        }
        public static bool validatePhoneNumber(NumericUpDown tlf)
        {
            if (tlf.Value > 699999999 || tlf.Value <= 600000000)
            {
                tlf.BackColor = Color.Red;
                return false;
            }
            tlf.BackColor = Color.White;
            return true;
        }

        public static bool validateTextBox(TextBox str)
        {
            if (String.IsNullOrEmpty(str.Text))
            {
                str.BackColor = Color.Red;
                return false;
            }
            str.BackColor = Color.White;
            return true;
        }
        public static bool validateMaskedTextBox(MaskedTextBox str)
        {
            if (String.IsNullOrEmpty(str.Text))
            {
                str.BackColor = Color.Red;
                return false;
            }
            str.BackColor = Color.White;
            return true;
        }
        public static bool validateRichTextBox(RichTextBox str)
        {
            if (String.IsNullOrEmpty(str.Text))
            {
                str.BackColor = Color.Red;
                return false;
            }
            str.BackColor = Color.White;
            return true;
        }
        public static bool validateComboBox(ComboBox str)
        {
            if (String.IsNullOrEmpty(str.Text))
            {
                str.BackColor = Color.Red;
                return false;
            }
            str.BackColor = Color.White;
            return true;
        }

        //Devuelve true si es valido el DNI
        public static bool validarDni(string dni)
        {
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                //No es un DNI Valido
                return false;
            }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido :)
            return true;
        }

        public static string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }

        //Ejemplo de validación de email sencillito.

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

        public static bool validateEmail(TextBox email)
        {
            try
            {
                var emailAddress = new MailAddress(email.Text);
            }
            catch (FormatException)
            {
                email.BackColor = Color.Red;
                return false;
            }
            catch (ArgumentException)
            {
                email.BackColor = Color.Red;
                return false;
            }
            email.BackColor = Color.White;
            return true;
        }
    }
}
