// See https://aka.ms/new-console-template for more information
// using System;

// namespace TypeConversion {
//     internal class Program {
//         static void Main(string[] args) {
//             float f = 123.4567F;
//             int i = Convert.ToInt32(f);
//             Console.WriteLine(i);
//         }
//     }
// }

// using System;

// namespace TypeConversion {
//     internal class Program {
//         static void Main(string[] args) {
//             float f = 3.142F;
//             int i = (int)f;
//             Console.WriteLine(i);
//         }
//     }
// }

// using System;
// namespace TypeConversion {
//     internal class P {
//         static void Main(string[] args) {
//             double f = 3.142D;
//             float i = (float)f;
//             Console.WriteLine(i);
//         }
//     }
// }


// using System;
// namespace TypeConversion {
//     internal class Program {
//         static void Main(string[] args) {
//             string strNumber = "100";
//             int result;
//             bool isConversionSuccessful = int.TryParse(strNumber, out result);
//             if(isConversionSuccessful) {
//                 Console.WriteLine(result);
//             } else {
//                 Console.WriteLine("Please enter a vaild variable");
//             }
//         }
//     }
// }