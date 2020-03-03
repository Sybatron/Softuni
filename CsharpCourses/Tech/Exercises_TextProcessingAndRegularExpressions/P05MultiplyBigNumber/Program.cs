using System;
using System.Text;

namespace P05MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = new StringBuilder(Console.ReadLine());
            var num2 = byte.Parse(Console.ReadLine());
            var multipliedNum = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                var letter = num1[i];
                multipliedNum = (num1[i] - '0') * num2;
                var j = i - 1;
                isThereRest(num1, multipliedNum, j);

                multipliedNum = multipliedNum % 10 + '0';
                num1[i] = (char)multipliedNum;
            }
            //{923847238931983192462832102}
            Console.WriteLine(num1);
        }

        private static void isThereRest(StringBuilder num1, int multipliedNum, int j)
        {
            while ((multipliedNum / 10 + num1[j - 1] - '0') / 10 > 0)
            {
                var rest = 0;
                if (j >= 0)
                {
                    rest = (multipliedNum / 10 + num1[j - 1] - '0') % 10 + '0';
                    num1[j] = (char)rest;
                    isThereRest(num1, multipliedNum, j);
                }
                else
                {
                    rest = multipliedNum / 10 % 10 + '0';
                    num1.Insert(0, "a");
                }
                j--;
            }
        }
    }
}
