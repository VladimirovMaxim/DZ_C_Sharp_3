// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceIn3D(double xa, double xb, double ya, double yb, double za, double zb)
{
    double xline = xa-xb, yline = ya - yb, zline = za - zb;
    double quadDist= (xline*xline) + (yline*yline) + (zline*zline);
    double longResult= Math.Sqrt(quadDist);
    double result = Math.Round(longResult,2);
    return result ;
}
Console.WriteLine("Введите координату x первой точки ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки  ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки ");
double zb = Convert.ToDouble(Console.ReadLine());

double dist = DistanceIn3D(xa, xb, ya, yb, za, zb);
Console.WriteLine("Расстояние мужду двумя точками равно " + dist );
