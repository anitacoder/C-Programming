using System;

class Point {
    public int x;
    public int y;

    // Overloading the bitwise NOT operator
    public static Point operator ~(Point Rvalue) {
        Point namePoint = new Point();
        namePoint.x = ~Rvalue.x; 
        namePoint.y = ~Rvalue.y; 
        
        return namePoint; 
    }

    public static void Main() {
        Point myPoint = new Point(); 
        myPoint.x = 5; 
        myPoint.y = 6; 
        Console.WriteLine(myPoint.x); 
        Console.WriteLine(myPoint.y); 
        myPoint = ~myPoint; 
        Console.WriteLine(myPoint.x); 
        Console.WriteLine(myPoint.y); 
    }
}
