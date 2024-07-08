// using System;


//     class Point2D
//     {
//         public int x;
//         public int y;
//     }

//     class Point3D : Point2D
//     {
//         public int z;
//     }

//     class MyMainClass
//     {
//         static void Main(string[] args)
//         {
//             Point2D my2DPoint = new Point2D();
//             Point3D my3DPoint = new Point3D();

//             my2DPoint.x = 100;
//             my2DPoint.y = 200;

//             my3DPoint.x = 150;
//             my3DPoint.y = 250;
//             my3DPoint.z = 350;

//             Console.WriteLine($"2D Point: x = {my2DPoint.x}, y = {my2DPoint.y}");
//             Console.WriteLine($"3D Point: x = {my3DPoint.x}, y = {my3DPoint.y}, z = {my3DPoint.z}");
//         }
//     }

using System;

class Point2D
{
    public int x;
    public int y;

    public virtual void PrintToConsole()
    {
        Console.WriteLine("{0}, {1}", x, y);
    }
}

class Point3D : Point2D
{
    public int z;

    public override void PrintToConsole()
    {
        Console.WriteLine("{0}, {1}, {2}", x, y, z);
    }
}

class MyMainClass
{
    public static void Main()
    {
        Point2D my2DPoint = new Point2D();
        Point3D my3DPoint = new Point3D();

        my2DPoint.x = 100;
        my2DPoint.y = 200;

        my3DPoint.x = 150;
        my3DPoint.y = 250;
        my3DPoint.z = 350;

        my2DPoint.PrintToConsole();
        my3DPoint.PrintToConsole();
    }
}
