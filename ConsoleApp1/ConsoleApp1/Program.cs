using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        double average = GetAverage(numbers);
        Console.WriteLine(average);

    }

    static double GetAverage(int[] numbers)
    {
        double sum = 0.0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
    
  

}