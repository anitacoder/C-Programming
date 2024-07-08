using System;

delegate int NumberChanger(int x);

namespace DelegateAppt {
    class TestDelegate {
        static int num = 10;

        public static int addNum(int a) {
            num += a;
            return num;
        }

        public static int multiplyNum(int b) {
            num *= b;
            return num;
        }

        public static void Main(string[] args) {
            NumberChanger number = new NumberChanger(addNum);
            NumberChanger number2 = new NumberChanger(multiplyNum);

            number(25);
            Console.WriteLine("Value of num after addition: " + num);

            number2(10);
            Console.WriteLine("Value of num after multiplication: " + num);
        }
    }
}
