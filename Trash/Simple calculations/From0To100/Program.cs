using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From0To100
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var word="";

            if(num==100)
            {
                word="one hundred";
            }
            else if (num >= 90)
            {
                word = "ninety ";
                switch (num % 10)
                {
                    case 1:
                        word+="one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if (num >= 80)
            {
                word = "eighty ";
                switch (num % 10)
                {
                    case 1:
                        word += "one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if (num >= 70)
            {
                word = "seventy ";
                switch (num % 10)
                {
                    case 1:
                        word += "one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if (num >= 60)
            {
                word = "sixty ";
                switch (num % 10)
                {
                    case 1:
                        word += "one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if (num >= 50)
            {
                word = "fifty ";
                switch (num % 10)
                {
                    case 1:
                        word += "one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if (num >= 40)
            {
                word = "forty ";
                switch (num % 10)
                {
                    case 1:
                        word += "one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if (num >= 30)
            {
                word = "thirty ";
                switch (num % 10)
                {
                    case 1:
                        word += "one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if (num >= 20)
            {
                word = "twenty ";
                switch (num % 10)
                {
                    case 1:
                        word += "one";
                        break;
                    case 2:
                        word += "two";
                        break;
                    case 3:
                        word += "three";
                        break;
                    case 4:
                        word += "four";
                        break;
                    case 5:
                        word += "five";
                        break;
                    case 6:
                        word += "six";
                        break;
                    case 7:
                        word += "seven";
                        break;
                    case 8:
                        word += "eight";
                        break;
                    case 9:
                        word += "nine";
                        break;
                }
            }
            else if(num>=10)
            {
                switch (num)
                {
                    case 10:
                        word="ten";
                        break;
                    case 11:
                        word = "eleven";
                        break;
                    case 12:
                        word = "twelve";
                        break;
                    case 13:
                        word = "thirteen";
                        break;
                    case 14:
                        word = "fourteen";
                        break;
                    case 15:
                        word = "fifteen";
                        break;
                    case 16:
                        word = "sixteen";
                        break;
                    case 17:
                        word = "seventeen";
                        break;
                    case 18:
                        word = "eighteen";
                        break;
                    case 19:
                        word = "nineteen";
                        break;
                }
            }
            else switch (num)
                {
                    case 1:
                        word = "one";
                        break;
                    case 2:
                        word = "two";
                        break;
                    case 3:
                        word = "three";
                        break;
                    case 4:
                        word = "four";
                        break;
                    case 5:
                        word = "five";
                        break;
                    case 6:
                        word = "six";
                        break;
                    case 7:
                        word = "seven";
                        break;
                    case 8:
                        word = "eight";
                        break;
                    case 9:
                        word = "nine";
                        break;
                }
            if(num>=20 && num<=90 && num%10==0)
            {
                word = word.Replace(" ", "");
            }

            Console.WriteLine(word);
        }
    }
}
