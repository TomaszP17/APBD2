﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine(GetAvg(new []{1,2,3,4,5}));

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}

static int getMaxValue(int[] arr)
{
    return arr.Max();
}