// See https://aka.ms/new-console-template for more information
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
        
//         Console.WriteLine($"Number == 10 is {isNumber10}");
//     }
// }

// using System;

// public class Program{
//     static void Main(){
//         float f = 123.4566F;
//         int i = (int)f;

//         Console.WriteLine(i);
//     }
// }


// using System;

// public class Program {
//     static void Main() {
//         string strNumber = "200";
//         int Result;
//         bool IsConvert = int.TryParse(strNumber, out Result);

//         if(IsConvert) {
//         Console.WriteLine(Result);
//         } else {
//             Console.WriteLine("Pls enter a valid number");
//         }
//     }
// }

// using System;

// public class Program {
//     static void Main() {
        // int[] array = new int[i];
        // array[0] = 1;
        // array[1] = 2;
        // array[2] = 3;
        // array[3] = 4;

        // console.WriteLine(array[2]);

        // Console.WriteLine("Please enter a number");
        // int numberEntered = int.Parse(Console.ReadLine());
        // if(numberEntered == 1) {
        //     Console.WriteLine("You entered 1");
        // } else if(numberEntered == 2) {
        //     Console.WriteLine("you entered 2");
        // } else if(numberEntered == 3) {
        //     Console.WriteLine("you entered 3");
        // } else {
        //     Console.WriteLine("Invalid number");
        // }

        // Console.WriteLine("Enter a name");
        // string nameEntered = Console.ReadLine();
        // if(nameEntered == "Anita") {
        //     Console.WriteLine("You entered the correct name");
        // } else if(nameEntered == "uche") {
        //     Console.WriteLine("You entered the wrong name");
        // } else {
        //     Console.WriteLine("Invalid name");
        // }

//        Console.WriteLine("Write your name");
//         string nameWritten = Console.ReadLine();

//         if (nameWritten == "Wasiu" || nameWritten == "Bayo" || nameWritten == "Benjamin") {
//             Console.WriteLine("Did you arrive on time? (yes/no)");
//             string arrivedOnTime = Console.ReadLine().ToLower();
            
//             if (arrivedOnTime == "yes") {
//                 Console.WriteLine("You are invited to the party");
//             } else {
//                 Console.WriteLine("You are not invited because you did not arrive on time");
//             }
//         } else {
//             Console.WriteLine("You are not invited");
//         }
//     }
// }


// using System;

// public class Calculator
// {
//     public int CalculateProduct(int num1, int num2)
//     {
//         return num1 * num2;
//     }

//     public void GetInputAndDisplayResult()
//     {
//         Console.WriteLine("Enter the first number:");
//         int number1 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the second number:");
//         int number2 = int.Parse(Console.ReadLine());

//         int product = CalculateProduct(number1, number2);

//         Console.WriteLine("The product of {0} and {1} is: {2}", number1, number2, product);
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Calculator calculator = new Calculator();
//         calculator.GetInputAndDisplayResult();
//     }
// }



// using System;

// public delegate void HelloFunction(string message);

// public class Program {

//     public void Display(string strMessage){
//         Console.WriteLine(strMessage);
//     }

//     public static void Main(string[] args)
//     {
//         Program P = new Program();

//         HelloFunction del = new HelloFunction(P.Display);

//         del("hello there");
//     }
// }

// using System;
// using System.Collections;

// namespace Polymorphism {
//     abstract class Animal {
//         public abstract void makeNoise();
//     }

//     class Cat : Animal {
//         public override void makeNoise()
//         {
//             Console.WriteLine("meow");
//         }
//     }

//     class Dog : Animal {
//         public override void makeNoise()
//         {
//             Console.WriteLine("barks");
//         }
//     }

//     class Program {
//         static void Main(string[] args)
//         {
//             ArrayList Zoo;
//             Zoo = new ArrayList(3);

//             Cat sasha, koshka;
//             sasha = new Cat();
//             koshka = new Cat();

//             Dog milou;
//             milou = new Dog();

//             Zoo.Add(milou);
//             Zoo.Add(koshka);
//             Zoo.Add(sasha);

//             foreach (Animal a in Zoo){
//                 a.makeNoise();
//             }
//         }
//     }
// }

// using System;

// public class Point {
//     public int x;
//     public int y;

//     public Point(){
//         x = 0;
//         y = 0;
//     }

//     public Point(int initailX, int initailY){
//         x = initailX;
//         y = initailY;
//         int Z = x - y;
//         Console.WriteLine(Z);
//     }
    
//     ~Point(){
//         x = 0;
//         y = 0;
//         int Z = x + y;
//     }
//     public static void Main(string[] args)
//     {
//         Point myfirstpoint = new Point(100, 200);
//         Point mysecondpoint = new Point();

//     }
// }

// using System;

// class Point {
//     private int XCoordinate;
//     private int YCoordinate;

//     public int X {
//         get {
//             return this.XCoordinate;
//         }
//         set {
//             if((value >= 0) && (value < 640)){
//                 this.XCoordinate = value;
//             }
//         }
//     }

//     public int Y {
//         get {
//             return this.YCoordinate;
//         }
//         set {
//             if((value >= 0) && (value < 480)){
//                 this.YCoordinate = value;
//             }
//         }
//     }

//     public static void Main(string[] args)
//     {
//         Point point = new Point();

//         point.X = 100;
//         point.Y = 200;
//         Console.WriteLine(point.X);
//         Console.WriteLine(point.Y);
//         point.X = 600;
//         point.Y = 600;
//         Console.WriteLine(point.X); 
//         Console.WriteLine(point.Y); 
//     }
// }

using System;

class Rainbow {
    public int GetNumberOfColors() {
        return 7;
    }

    public bool getColor(int ColorIndex, out string colorName) {
        bool ReturnValue = true;

        switch(ColorIndex) {
            case 0:
                colorName = "Red";
                break;
            case 1:
                colorName = "Orange";
                break;
            case 2:
                colorName = "Yellow";
                break;
            case 3:
                colorName = "Green";
                break;
            case 4:
                colorName = "Blue";
                break;
            case 5:
                colorName = "Indigo";
                break;
            case 6:
                colorName = "Violet";
                break;
            default:
                colorName = "";
                ReturnValue = false;
                break;
        }
        return ReturnValue;
    }

    public static void Main(string[] args) {
        Rainbow rainbow = new Rainbow();
        int colorCount = rainbow.GetNumberOfColors();
        string colorName;
        bool success;

        for (int colorIndex = 0; colorIndex < colorCount; colorIndex++) {
            success = rainbow.getColor(colorIndex, out colorName);
            if (success) {
                Console.WriteLine(colorName);
            }
        }
    }
}
