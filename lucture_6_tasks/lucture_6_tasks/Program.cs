using System;

namespace lucture_6_tasks {
    class Program {
        static void Main(string[] args) {
            EmptyArray();
            Task2();
            Task3();
            Task4();
        }

        static void EmptyArray() {
            // emty array is imposible
            int[] array = new int[3];
            Console.WriteLine("Emty array is imposible");
            Console.WriteLine(string.Join(", ", array));
        }

        static void Task2() {
            object[] array = new object[3];

            array[0] = 32;
            array[1] = 'A';
            array[2] = "Hello";

            Console.WriteLine(string.Join(", ", array));

            int num = Convert.ToInt32(array[0]);

            array[0] = num + 10;
            array[2] += ", guys!";

            Console.WriteLine(string.Join(", ", array));

        }

        static void Task3() {
            int arraySize = 10;
            int[] array = new int[arraySize];
            Random rand = new Random();
            int max = 0;
            int arrayNum = 0;

            for (int i = 0; i < arraySize; i++) {
                arrayNum = rand.Next(1, 100);
                array[i] = arrayNum;

                if (max < arrayNum) {
                    max  = arrayNum;
                }
            }

            Console.WriteLine("Array:");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine("Array max value: " + max);
        }

        static void Task4() {
            short num = 123;
            int num2 = num;
            sbyte num3 = (sbyte)num2;

            Console.WriteLine("result num: " + num3 + "\n" +
                "num type " + num3.GetType());
        }
    }
}
