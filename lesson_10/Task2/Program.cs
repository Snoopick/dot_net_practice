using System;

namespace Task2 {
    class Program {
        static void Main(string[] args) {
            UniqueItem test1 = new UniqueItem();
            UniqueItem test2 = new UniqueItem();
            UniqueItem test3 = new UniqueItem(5);
            UniqueItem test4 = new UniqueItem();
            UniqueItem test5 = new UniqueItem();

            Console.WriteLine(test5.getNum());
        }
    }

    class UniqueItem {
        public int _counter;

        public UniqueItem(int counter = 0) {
            if (counter != 0) {
                this._counter = counter;
            }

            this._counter++;
        }

        public int getNum() {
            return this._counter;
        }
    }
}
