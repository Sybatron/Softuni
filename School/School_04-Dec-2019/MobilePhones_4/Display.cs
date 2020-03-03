using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MobilePhones_4
{
    public class Display
    {
        public double DisplayInches { get; private set; }

        public string DisplayColors { get; private set; }

        public Display(double displayInches, string displayColors)
        {
            var colorsPattern = new Regex(@"[1-9]\d{0,1} M");
            if (colorsPattern.IsMatch(displayColors.ToString()))
            {
                DisplayInches = displayInches;
                DisplayColors = displayColors;
            }
            else
            {
                Console.WriteLine("Цветовете на дисплея не са във формат число M");
                return;
            }
        }
    }
}
