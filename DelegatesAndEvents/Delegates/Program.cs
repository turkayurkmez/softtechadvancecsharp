// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("Hello, World!");
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var result1 = FilterProcess.Filter(numbers, isEven);
showArray(result1);

var result2 = FilterProcess.Filter(numbers,
    delegate (int x)
    {
        return x % 3 == 0;
    });
showArray(result2);

var result3 = FilterProcess.Filter(numbers, x =>  x > 5);
showArray(result3);




static bool isEven(int number)
{
    return number % 2 == 0;
}

static void showArray(int[] array)
{
    Console.WriteLine("---------------------------");
    foreach (var number in array)
    {
        Console.WriteLine(number);
    }
}

static void alternativeShowArray(int[] array)
{
    Console.WriteLine("---------------------------");
    array.ToList().ForEach(x => Console.WriteLine(x));
    
}



