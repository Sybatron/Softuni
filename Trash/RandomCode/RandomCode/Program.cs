using System;

namespace RandomCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass customClass = new CustomClass();
            customClass["Kor"] = 69;
            Console.WriteLine(customClass["Kor"]);
        }
    }
}
