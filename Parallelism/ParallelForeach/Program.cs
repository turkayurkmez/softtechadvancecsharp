// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

var maxNumber = 2000000;
var numbers = Enumerable.Range(1, maxNumber).ToList();
var watch = Stopwatch.StartNew();
var primeNumbersNormal = GetPrimeNumbers(numbers);
watch.Stop();

var watchForParallel = Stopwatch.StartNew();
var primeNumbersParallel = GetPrimeListWithParallelForeach(numbers);
watchForParallel.Stop();

Console.WriteLine($"Normal foreach: {watch.ElapsedMilliseconds} ms");
Console.WriteLine($"Parallel foreach: {watchForParallel.ElapsedMilliseconds} ms");

var evenNumbers = from number in numbers.AsParallel()
                  where number % 2 == 0
                  select number;
Console.WriteLine($"Even numbers: {evenNumbers.Count()}");

static bool isPrime(int number)
{
    if (number < 2)
        return false;
    if (number == 2)
        return true;
    if (number % 2 == 0)
        return false;

    for (int i = 3; i * i <= number; i += 2)
        if (number % i == 0)
            return false;

    return true;
}

static IList<int> GetPrimeNumbers(IList<int> numbers) => numbers.Where(isPrime).ToList();

static IList<int> GetPrimeListWithParallelForeach(IList<int> numbers)
{
    var result = new ConcurrentBag<int>();
    Parallel.ForEach(numbers, number =>
    {
        if (isPrime(number))
            result.Add(number);
    });
    return result.ToList();
}