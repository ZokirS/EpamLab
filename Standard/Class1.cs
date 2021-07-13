using System;
using System.Globalization;

namespace standard
{
    public class Class1
    {
        public string GetCurrentTime(string name)
        {
            DateTime localDate = DateTime.Now;
            string ruCulture = "ru-RU";
            var culture = new CultureInfo(ruCulture);

            var res = $"{localDate.ToString(culture)} Hello {name}";

            return res;
        }
    }
}
