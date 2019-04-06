using System;

namespace P04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();
            PaswordValidator(password);

        }

        private static void PaswordValidator(string password)
        {
            //•	"Password must be between 6 and 10 characters"
            //•	"Password must consist only of letters and digits"
            //•	"Password must have at least 2 digits"

            bool inRange = IsPasswordInRange(password);
            bool onlyLettersDigits = IsPaswordOnlyLettersDigits(password);
            bool least2Digits = IsPaswordLeast2Digits(password);

            if (inRange && onlyLettersDigits && least2Digits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!inRange)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!onlyLettersDigits)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!least2Digits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool IsPasswordInRange(string password)
        {
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsPaswordOnlyLettersDigits(string password)
        {
            foreach (var character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool IsPaswordLeast2Digits(string password)
        {
            int digitsCounter = 0;
            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    if (digitsCounter < 2)
                    {
                        digitsCounter++;
                        if (digitsCounter == 2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
