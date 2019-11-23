using System;

namespace Task2 {
    class Program
    {
        public static int iterator;

        static void Main(string[] args)
        {
            UniqueItem test1 = new UniqueItem();
            UniqueItem test2 = new UniqueItem();
            UniqueItem test3 = new UniqueItem(5);
            UniqueItem test4 = new UniqueItem();
            UniqueItem test5 = new UniqueItem();
        }
    }

    class UniqueItem
    {
        private int _counter;

        public UniqueItem(int counter = 0)
        {
            this._counter = Program.iterator;

            if (counter != 0)
            {
                this._counter += counter;
            }

            this._counter++;
            Program.iterator = this._counter;

            Console.WriteLine("Num is " + this._counter);
        }
    }
}
