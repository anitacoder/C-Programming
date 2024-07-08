// using System;

// public struct Mystruc {
//     public string[] data;
// }

// public class Program {
//     public static void Main(string[] args) {
//         Mystruc obj = new Mystruc();
//         obj.data = new string[5];
//         obj.data[0] = "I am a man";
//         obj.data[1] = "I am a man";
//         obj.data[2] = "I am a man";
//         obj.data[3] = "I am a man";
//         obj.data[4] = "I am a man";

//         // Use a for loop to display the elements
//         for (int i = 0; i < obj.data.Length; i++) {
//             Console.WriteLine(obj.data[i]);
//         }
//     }


// using System;

// public class Program {
//     public static void Main() {
//         int number = 10;
//         bool isNumber10;
        
//         if(number == 10) {
//             isNumber10 = true;
//         } else {
//             isNumber10 = false;
//         }
        
//         // Corrected Console.WriteLine method
//         Console.WriteLine($"Number == 10 is {isNumber10}");
//     }
// }


using System;

public class ClassA {
    
    public int Sum(int a, int b){
        return a + b;
    }

    public static int Product(int a, int b){
        return a * b;
    }

    public static void Main(string[] args){
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine());

        ClassA obj = new ClassA();
        int sum = obj.Sum(a, b);
        Console.WriteLine("The sum is: " + sum);

        int product = ClassA.Product(a, b);
        Console.WriteLine("The product is: " + product);
    }
}
