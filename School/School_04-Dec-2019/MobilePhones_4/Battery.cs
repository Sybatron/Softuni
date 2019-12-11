using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MobilePhones_4
{
    public class Battery
    {
        public string Model { get; private set; }
        public string HoursEndurance { get; private set; }
        public string Mah { get; private set; }

        public Battery(string model, string hoursEndurance, string mah)
        {
            var hoursPattern = new Regex(@"[1-9]\d{0,} [Hh]");
            var mahPattern = new Regex(@"[1-9]\d{0,} mAh");

            if (hoursPattern.IsMatch(hoursEndurance))
            {
                if (mahPattern.IsMatch(mah))
                {
                    Model = model;
                    HoursEndurance = hoursEndurance;
                    Mah = mah;
                }
                else
                {
                    Console.WriteLine("mah на батерията не е във формат число mAh");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Издръжливостта на батерията не е във формат число H или число h");
                return;
            }
        }
    }
}
