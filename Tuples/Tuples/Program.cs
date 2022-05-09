// See https://aka.ms/new-console-template for more information
using Tuples;

Console.WriteLine("Hello, World!");

int outResult = 0;
int divideResult = divide(19, 3, out outResult);
Console.WriteLine($"Bölüm: {divideResult}, kalan: {outResult}");

var objectResult = divideWithObject(19, 3);
Console.WriteLine($"Bölüm: {objectResult.Result}, kalan: {objectResult.Modulo}");

var tupleResult = divideWithTuple(19, 3);
Console.WriteLine($"Bölüm: {tupleResult.Item1}, kalan: {tupleResult.Item2}");

//Tuple'in dezavantajı:
//Tuple<string,int,double,byte,string,decimal,char> tuple = Tuple.Create("a",5,4.0,(byte)1,"",1.0M,'a') ;



static int divide(int a, int b, out int modulo)
{
    modulo = a % b;
    return a / b;
}

static DivisonResult divideWithObject(int a, int b)
{
    var result = new DivisonResult();
    result.Result = a / b;
    result.Modulo = a % b;

   return result;
}

static Tuple<int, int> divideWithTuple(int a, int b)
{
    Tuple<int, int> tuple = Tuple.Create<int, int>(a / b, a % b);
  
    return tuple;

}

