// See https://aka.ms/new-console-template for more information
using GenericTypes;

Console.WriteLine("Hello, World!");
//boxing:
object value = "deneme";
//int strValue = (int)value; 

GeneralPoint generalPoint = new GeneralPoint();

generalPoint.X = 25;
generalPoint.Y = 30.5;

GenericPoint<double> point = new GenericPoint<double>();
point.X = 5.3;
point.Y = 50.05;
Console.WriteLine(point);

GenericPoint<decimal> decimalPoint = new GenericPoint<decimal>();
decimalPoint.X = 0.0000001M;
decimalPoint.Y = 0.0000001M;
decimalPoint.IsEqualPoints();




point.Reset();
Console.WriteLine(point);

static int add<T>(T t1, T t2) where T : struct, IComparable<T>
{
    return 0;
}