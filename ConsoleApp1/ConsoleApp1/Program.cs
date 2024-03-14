using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        double sum = GetSum(numbers);
        double average = CalculateAverage(numbers);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);

    }

    static double CalculateAverage(int[] numbers)
    {
        double sum = 0.0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
    
    static double GetSum(int[] numbers)
    {
        double sum = 0.0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}