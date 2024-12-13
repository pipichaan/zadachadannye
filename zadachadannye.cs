using System;
using System.IO;

class MyProgram
{
    static void Main(string[] args)
    {
        try
        {
            string inputText = File.ReadAllText("C:\\Users\\alina\\OneDrive\\Рабочий стол\\2 курс\\Zadacha_dannye.txt");
            int maximumPairs = MAx(inputText);
            Console.WriteLine("макс. пар =  " + maximumPairs);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    static int MAx(string inputText)
    {
        int maxCount = 0;
        int currentCount = 0;

        for (int index = 0; index < inputText.Length - 1; index++)
        {
            string cur = inputText.Substring(index, 2);
            if (cur == "AB" || cur == "CB")
            {
                currentCount++;
                index++;
            }
            else
            {
                maxCount = Math.Max(maxCount, currentCount);
                currentCount = 0;
            }
        }

        maxCount = Math.Max(maxCount, currentCount);
        return maxCount;
    }
}