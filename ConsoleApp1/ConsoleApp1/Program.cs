// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine(GetAvg(new []{1,2,3,4,5}));

static double GetAvg(int[] arr)
{
    int suma = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        suma += arr[i];
    }

    return suma / arr.Length;
}

static int getMaxValue(int[] arr)
{
    return arr.Max();
}