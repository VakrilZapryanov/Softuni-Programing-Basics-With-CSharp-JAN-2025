﻿string input = Console.ReadLine();
int minNum = int.MaxValue;
while (input != "Stop")
{
    int num = int.Parse(input);

    if (num < minNum)
    {
        minNum = num;
    }

    input = Console.ReadLine();
}

if (input == "Stop")
{
    Console.WriteLine(minNum);
}