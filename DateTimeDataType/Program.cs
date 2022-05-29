using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToShortDateString());
            Console.WriteLine(simdi.ToLongDateString());
            Console.WriteLine(simdi.ToShortTimeString());
            Console.WriteLine(simdi.ToLongTimeString());

            Console.WriteLine(simdi.Month + "/" + simdi.Day + "/" + simdi.Year + " " + simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second + "." + simdi.Millisecond);

            DateTime tarih = new DateTime(2020, 11, 28, 19, 17, 0);
            Console.WriteLine(tarih);

            tarih = DateTime.Parse("04.12.2021" , new CultureInfo("tr")); // en
            Console.WriteLine(tarih);
            tarih = DateTime.Parse("04/13/2021 16:01:25", new CultureInfo("en"));
            string tarihText = tarih.ToString(new CultureInfo("en"));
            Console.WriteLine(tarihText);
            tarihText = tarih.ToString("yyyy-MM-dd  HH:mm:ss");
            Console.WriteLine(tarihText);

            simdi = DateTime.Now;
            Console.WriteLine("Yarın : " + simdi.AddDays(1));
            Console.WriteLine("1 hafta öncesi : " + simdi.AddDays(-7));
            Console.WriteLine("6 ay sonrası: " + simdi.AddMonths(6).ToShortDateString());
            Console.WriteLine("2 sene sonrası : " + simdi.AddYears(2).ToLongDateString());
            Console.WriteLine("12 saat sonrası : " + simdi.AddHours(12));
            Console.WriteLine("Yarım saat öncesi : " + simdi.AddMinutes(-30));

            var tarih1 = DateTime.Parse("01.10.2020");
            var tarih2 = DateTime.Parse("20.10.2020");
            if (tarih2.CompareTo(tarih1) > 0 )
            {
                Console.WriteLine("tarih2 > tarih1");
            }
            else if (tarih2.CompareTo(tarih1) < 0)
            {
                Console.WriteLine("tarih2 < tarih1");
            }
            else
            {
                Console.WriteLine("tarih2 = tarih1");
            }
            if (tarih2 > tarih1)
            {
                Console.WriteLine("tarih2 > tarih1");
            }
            else if (tarih2 < tarih1)
            {
                Console.WriteLine("tarih2 < tarih1");
            }
            else
            {
                Console.WriteLine("tarih2 = tarih1");
            }

            Console.WriteLine(simdi.Date);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(simdi.DayOfWeek + "  " + (int)simdi.DayOfWeek);

            Console.ReadLine();
        }
    }
}
