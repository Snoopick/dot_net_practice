using System;

namespace classEx_9 {
    class Program {
        static void Main(string[] args) {
            string[] resultArray = new String[3];
            Random rand = new Random();
            int rendNum = rand.Next(1, 10);
            Circle circle = new Circle(rendNum);
            Square square = new Square(rendNum);
            Triangle triangle = new Triangle(rendNum, rand.Next(1, 10));


            resultArray[0] = circle.Print();
            resultArray[1] = square.Print();
            resultArray[2] = triangle.Print();

            for (int i = 0; i < resultArray.Length; i++) {
                Console.WriteLine(resultArray[i]);
            }
        }
    }

    interface IFigures {
        double CalcSquare();
        string Print();
    }

    class Circle : IFigures {
        private int radius;
        private double square;
        private string name = "Circle";

        public Circle(int radius) {
            this.radius = radius;
        }


        public double CalcSquare() {
            this.square = Math.PI * Math.Pow(this.radius, 2);
            return this.square;
        }

        public string Print() {
            return "This is " + this.name + ". CLR Type is " + this.radius + ". Square is " + this.CalcSquare();
        }
    }

    class Square : IFigures {
        private int side;
        private double square;
        private string name = "Square";

        public Square(int side) {
            this.side = side;
        }

        public double CalcSquare() {
            this.square = this.side * this.side;
            return this.square;
        }

        public string Print() {
            return "This is " + this.name + ". CLR Type is " + this.side + ". Square is " + this.CalcSquare();
        }
    }

    class Triangle : IFigures {
        private int sides;
        private int bottom;
        private double square;
        private string name = "Triangle";

        public Triangle(int sides, int bottom) {
            this.sides = sides;
            this.bottom = bottom;
        }

        public double CalcSquare() {
            this.square = this.bottom / 4 * Math.Sqrt(4 * Math.Pow(this.sides, 2) - Math.Pow(this.bottom, 2));

            return this.square;
        }

        public string Print() {
            return "This is " + this.name + ". CLR Type is [" + this.sides + ", " + this.bottom + "]. Square is " + this.CalcSquare();
        }
    }
}

