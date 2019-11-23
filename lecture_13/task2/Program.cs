using System;

namespace task2 {
    class Program {
        static void Main(string[] args) {
            string testString = "Just a cuteble strung";

            Console.WriteLine(testString.CuteString(testString));
        }
    }

    static class StringExtensions {

        public static string CuteString(this String outputString, string inputString) {
            int iterator = 0;
            string newString = string.Empty;

            foreach (var item in inputString) {
                if (iterator == 5) {
                    newString += "...";

                    break;
                }

                newString += item;
                iterator++;
            }

            return newString;
        }
    }
}
