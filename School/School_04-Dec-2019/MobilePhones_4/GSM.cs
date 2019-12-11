using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhones_4
{
    public class GSM
    {
        public string Model { get; private set; }

        public string Producer { get; private set; }

        public double Price { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public GSM(string model, string producer, double price, Battery battery, Display display)
        {
            try
            {
                Model = model;
                Producer = producer;
                Price = price;

                Battery = new Battery(battery.Model, battery.HoursEndurance, battery.Mah);
                Display = new Display(display.DisplayInches, display.DisplayColors);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"{Producer} {Model} е невалиден - {DateTime.Now}!");

            }
        }

        public GSM()
        {
            Model = "Redmi Note 4X";
            Producer = "Xiaomi";
            Price = 300;
            Battery = new Battery("Non-removable Li-Po", "48 h", "4100 mAh");
            Display = new Display(5.5, "16 M");
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            try
            {
                info.AppendLine($"Телефон: {Producer} {Model}");
                info.AppendLine($"Цена: {Price} лв.");
                info.AppendLine($"Батерия: {Battery.Model} {Battery.Mah}, издържа до {Battery.HoursEndurance}");
                info.AppendLine($"Дисплей: {Display.DisplayInches} инча, {Display.DisplayColors} цвята");
            }
            catch (NullReferenceException)
            {
                info = new StringBuilder($"Невалиден телефон!");
            }

            return info.ToString();
        }
    }
}
