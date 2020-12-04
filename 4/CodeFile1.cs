using System;

class UngaBung
{
    static void Main()
    {
        int prev = 0;
        int current = 1;
        int temp;
        int Collischestvo;
        int i = 0;

        Console.WriteLine("Enter a col of fibbonachi numbers!");
        Collischestvo = Int32.Parse(Console.ReadLine());
        Console.Clear();

        do
        {
            Console.WriteLine(current);
            temp = current;
            current = current + prev;
            prev = temp;
            i++;
        }

        while (i < Collischestvo);

        Console.ReadKey();

    }
}