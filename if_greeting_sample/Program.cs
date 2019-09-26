using System;

namespace if_greeting_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan nowTime = DateTime.Now.TimeOfDay;

            int nowHour = nowTime.Hours;


            if (nowHour > 9 && nowHour < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (nowHour > 12 && nowHour < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (nowHour > 15 && nowHour < 22)
            {
                Console.WriteLine("Good evening, guys");
            }
            else if (nowHour > 22 && nowHour < 9) {
                Console.WriteLine("Good morning, guys");
            }
        }
    }
}
