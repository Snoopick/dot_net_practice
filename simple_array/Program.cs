using System;

namespace simple_array {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++) {
                array[i] = rnd.Next(0, 50);
            }

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Changed array");
            for (int i = 0; i < array.Length; i++) {
                if (i == 3) {
                    array[i] *= 10;
                }

                Console.WriteLine(array[i]);
            }

            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > max) {
                    max = array[i];
                }

                if (array[i] < min) {
                    min = array[i];
                }
            }

            Console.WriteLine("Max num");
            Console.WriteLine(max);

            Console.WriteLine("Min num");
            Console.WriteLine(min);
        }
    }
}
