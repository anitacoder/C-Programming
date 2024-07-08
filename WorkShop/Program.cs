// See https://aka.ms/new-console-template for more information
// using System;

// namespace Parameters {
//     public class NumberPointer {
//         void numbers(int num1, int num2, int num3, int num4, int num5, int num6) {
//             Console.WriteLine("The following numbers are: " + num1 + " " + num2 + " " + num3 + " " + num4 + " " + num5 + " " + num6);
//         }
//         public static void Main(string[] args) {
//             NumberPointer obj = new NumberPointer();
//             obj.numbers(3,6,9,12,15,18);
//         }
//     }
// }

using System;

namespace CubeOfNumbers {
    public class CubeNumbers {
        public static void cube(ref int a) {
            a = a * a * a;
        }
        public static void Main(string[] args) {
            int number = 3;
            cube(ref number);
            Console.WriteLine("The cube of the number is: " + number);
        }
    }
}