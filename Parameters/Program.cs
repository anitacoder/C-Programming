// See https://aka.ms/new-console-template for more information
// using System;

// namespace calculatorApp {
//     public class NumberMalpulator {
//         public void getValue(out int x) {
//         int temp = 5;
//         x = temp;
//         }
    
//     public static void Main(string[] args) {
//         NumberMalpulator n = new NumberMalpulator();
//         int a = 100;
//         Console.WriteLine($"Before calling method, value of a is: {a}");
//         n.getValue(out a);
//         Console.WriteLine($"After calling method, value of a is: {a}");
//         }
//     }
// }

using System;

namespace calculatorApp {
    public class NumberMalpulator {
        public void swap(ref int x, ref int y) {
        int temp;
        temp = x;
        x = y;
        y = temp;
        }
    
    public static void Main(string[] args) {
        NumberMalpulator n = new NumberMalpulator();
        int a = 100;
        int b = 200;
        Console.WriteLine("Before calling method, value of a is:" + a);
        Console.WriteLine("Before calling method, value of b is:" + b);
        n.swap(ref a, ref b);
            Console.WriteLine($"After calling method, value of a is: {a}");
            Console.WriteLine($"After calling method, value of b is: {b}");
        }
    }
}

