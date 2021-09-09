using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            //all of these strings are arrays that will check to see if the password the user enters qualifies for a point
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string didgets = "1234567890";
            string specialChars = "!@#$%^&*-+";
           
            Console.Write("Enter your password: ");
            string passWord = Console.ReadLine();
            //if the statement is true, add to the score (Max of 5)
            int score = 0;
            if (passWord.Length > minLength)
            {
                score++;
            }
            if (Tools.Contains(passWord, uppercase))
            {
                score++;
            }
            if (Tools.Contains(passWord, lowercase))
            {
                score++;
            }
            if (Tools.Contains(passWord, didgets))
            {
                score++;
            }
            if (Tools.Contains(passWord, specialChars))
            {
                score++;
            }

            string comment;
            //adds a comment to the score
            switch (score)
            {
                case 1:
                    comment = "your password is weak.";
                    break;
                case 2:
                    comment = "your password is moderatly strong.";
                    break;
                case 3:
                    comment = "your password is strong!";
                    break;
                case 4:
                    comment = "your password is verry strong!";
                    break;
                case 5:
                    comment = "your password is extremely strong!";
                    break;
                default:
                    comment = "bruh";
                    break;
            }
            Console.WriteLine(score + " " + comment);
            Console.ReadKey();
        }
    }
}

