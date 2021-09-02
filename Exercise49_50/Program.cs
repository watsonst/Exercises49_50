using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercise49_50
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = "q";
            List<Square> squareList = new List<Square>();
            int parsedSideLength = 0;

            do
            {
                Console.Write("Enter a side length (q to quit): ");
                userInput = Console.ReadLine().ToLower();


                bool success = int.TryParse(userInput, out parsedSideLength);
                if (success)
                {
                    Square s = new Square(parsedSideLength);
                    squareList.Add(s);
                }
                else
                {
                    break;
                }


            } while (userInput != "q");

            var maxNum = squareList.Max(z => z.SideLength );
            Console.WriteLine($"Largest: {maxNum}");

            var minNum = squareList.Min(z => z.SideLength);
            Console.WriteLine($"Smallest: {minNum}");

            var totalArea = 0;

            foreach (Square s in squareList)
            {
                totalArea += s.Area;
            }

            var averageArea = totalArea / squareList.Count;
            Console.WriteLine($"Average Area: {averageArea}");


           var totalPerimeter = 0;

            foreach (Square s in squareList)
            {
                totalPerimeter += s.Perimeter;
            }

            var averagePerimeter = totalPerimeter / squareList.Count;
            Console.WriteLine($"Average Perimeter: {averagePerimeter}");



                //}

                //var averagePerimeter = squareList.SelectMany(x=> x).Average();
                // Console.WriteLine($"Average Perimeter: {averagePerimeter}");


                //largest 
                //smallest





            }



    }


    class Square
    {
        private int _sideLength = 0;
        private int _area = 0;
        private int _perimeter = 0;

        public int SideLength
        {
            get { return _sideLength; }
            set { _sideLength = value; }
        }

        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public int Perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }
        }


        public Square(int SideLength)
        {
            this._sideLength = SideLength;
            this._area = GetArea(this._sideLength);
            this._perimeter = GetPerimeter(this._sideLength);

        }

        public int GetArea(int sideLength)
        {

            int area = sideLength * sideLength; 
            return area;
        }

        public int GetPerimeter(int sideLength)
        {

            int perimeter = sideLength * 4;
            return perimeter;
        }



    }

}
