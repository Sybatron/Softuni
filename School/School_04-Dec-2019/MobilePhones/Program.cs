using System;

namespace MobilePhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultPhone = new GSM();
            var customPhone = new GSM(
                "Redmi Note 7",
                "Xiaomi",
                375.50,
                new Battery("Non-removable Li-Po", "48 H", "5000 mAh"),
                new Display(6, "24 M")
                );

            var wrongPhone = new GSM(
                "Redmi Note 7",
                "Xiaomi",
                375.50,
                new Battery("Non-removable Li-Po", "48 MAH", "5000 mAh"),
                new Display(6, "24 M")
                );

            Console.WriteLine(defaultPhone + Environment.NewLine);
            Console.WriteLine(customPhone + Environment.NewLine);
            Console.WriteLine(wrongPhone);

        }
    }
}
