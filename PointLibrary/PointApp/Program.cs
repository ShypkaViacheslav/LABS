// Program.cs - Консольний додаток для взаємодії з PointLibrary
using System;
using PointLibrary;

class Program
{
    static void Main()
    {
        // Введення координат першої точки
        Console.WriteLine("Введіть координати першої точки (x y z):");
        var input1 = Console.ReadLine().Split();
        double x1 = double.Parse(input1[0]);
        double y1 = double.Parse(input1[1]);
        double z1 = double.Parse(input1[2]);
        Point3D point1 = new Point3D(x1, y1, z1);

        // Введення координат другої точки
        Console.WriteLine("Введіть координати другої точки (x y z):");
        var input2 = Console.ReadLine().Split();
        double x2 = double.Parse(input2[0]);
        double y2 = double.Parse(input2[1]);
        double z2 = double.Parse(input2[2]);
        Point3D point2 = new Point3D(x2, y2, z2);

        // Обчислення відстаней
        Console.WriteLine($"Відстань від першої точки до початку координат: {point1.DistanceToOrigin()}");
        Console.WriteLine($"Відстань між першою і другою точками: {point1.DistanceTo(point2)}");

        // Введення кольорової точки
        Console.WriteLine("Введіть координати кольорової точки (x y z) і колір:");
        var input3 = Console.ReadLine().Split();
        double x3 = double.Parse(input3[0]);
        double y3 = double.Parse(input3[1]);
        double z3 = double.Parse(input3[2]);
        string color = input3[3];
        ColoredPoint3D coloredPoint = new ColoredPoint3D(x3, y3, z3, color);

        // Виведення інформації про кольорову точку
        Console.WriteLine($"Кольорова точка: ({coloredPoint.X}, {coloredPoint.Y}, {coloredPoint.Z}), Колір: {coloredPoint.Color}");
    }
}
