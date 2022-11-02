// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = new int[5] { 1, 12, 6, 8, 10};

static int BitwiseNumberOfEven(int[] numbers)
{
    int counter = 0;

    for (var i = 0; i < numbers.Length; i++)
    {
        int add = numbers[i] & 1;
        counter += (1 - add);
    }

    return counter;
}
