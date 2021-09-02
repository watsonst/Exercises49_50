//using System;
//using System.Collections.Generic;

//namespace Exercise_50
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var userInput = "q";
//            List<Triangle> triangleList = new List<Triangle>();
//            int SideLength = 0;

//            do
//            {
//                Console.Write("Enter a side length (q to quit): ");
//                userInput = Console.ReadLine();

//                bool success = int.TryParse(userInput, out SideLength);
//                if (success)
//                {
//                    triangleList.Add(sideLength);
//                }
//                else
//                {
//                    break;
//                }


//            } while (userInput != "q");
//        }
//    }

//    class Triangle 
//    {
//        public int sideLength { get; set; }
//    }
//}
