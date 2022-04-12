using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int randomNumber = random.Next(1,1024);
        int degreeNumber = 2;
        int degree = 1;
        int number = degreeNumber;
        bool isSearchActive = true;

        while (isSearchActive == true)
        {
            number *= degreeNumber;
            degree++;

            if (number > randomNumber)
            {
                isSearchActive = false;
            }
        }
        Console.WriteLine($"Случайное число: {randomNumber}\n{degreeNumber} в {degree} степени - {number}");
    }
}