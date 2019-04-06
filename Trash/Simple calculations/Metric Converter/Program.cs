using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
                var value = double.Parse(Console.ReadLine());
                var inputMetric = Console.ReadLine().ToLower();
                var outputMetric = Console.ReadLine().ToLower();


                var result = 0.0;
                switch (inputMetric)
                {
                    case "cm":
                        result = value / 100;
                        break;
                    case "mi":
                        result = value / 0.000621371192;
                        break;
                    case "in":
                        result = value / 39.3700787;
                        break;
                    case "km":
                        result = value / 0.001;
                        break;
                    case "ft":
                        result = value / 3.2808399;
                        break;
                    case "yd":
                        result = value / 1.0936133;
                        break;
                    default:
                        result = value;
                        break;
                }

                switch (outputMetric)
                {
                    case "cm":
                        result = result * 100;
                        break;
                    case "mi":
                        result = result * 0.000621371192;
                        break;
                    case "in":
                        result = result * 39.3700787;
                        break;
                    case "km":
                        result = result * 0.001;
                        break;
                    case "ft":
                        result = result * 3.2808399;
                        break;
                    case "yd":
                        result = result * 1.0936133;
                        break;
                    default:
                        break;
                }

                Console.WriteLine(result + " " + outputMetric);
        }
    }
}
