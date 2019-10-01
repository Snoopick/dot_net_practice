using System;

namespace simple_array {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("Enter num");
                array[i] = Convert.ToInt32(Console.ReadLine());
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
        }
    }
}
