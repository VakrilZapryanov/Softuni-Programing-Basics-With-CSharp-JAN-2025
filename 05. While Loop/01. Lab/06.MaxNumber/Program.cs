﻿string input = Console.ReadLine();
int maxNum = int.MinValue;

while (input != "Stop")
{
    int num = int.Parse(input);

    if (num > maxNum)
    {
        maxNum = num;
    }

    input = Console.ReadLine();
}

if (input == "Stop")
{
    Console.WriteLine(maxNum);
}