// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
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
*/
/*
int value = 21;
Console.WriteLine(value << 2);

int boolValue = value & 1;
Console.WriteLine(boolValue);
*/
int[] numbers = new int[5] {10, 3, 1, 9, 0};

/* SORT ALGO
static int[] SortAlgo(int[] numbers)
{
    int reservoir;

    for (var i = 0; i < numbers.Length; i++)
    {
        for (var j = 0; j < numbers.Length; j++)
        {
            if(numbers[i] < numbers[j])
            {
                reservoir = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = reservoir;
            }
        }
    }
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
    return numbers;
}

Console.WriteLine(SortAlgo(numbers));
*/

static int[] SortAlgoWithoutThirdVariable(int[] numbers)
{
    for (var i = 0; i < numbers.Length; i++)
    {
        for (var j = 0; j < numbers.Length; j++)
        {
            if (numbers[i] < numbers[j])
            {
                numbers[i] = numbers[i] + numbers[j];
                numbers[j] = numbers[i] - numbers[j];
                numbers[i] = numbers[i] - numbers[j];
            }
        }
    }
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
    return numbers;
}

Console.WriteLine(SortAlgoWithoutThirdVariable(numbers));



static int MiddleOfNumber(int n)
{
    int digits = (int) Math.Log10(n) + 1;
    int middle = (int) (n/(Math.Pow(10, digits/2))) % 10;

    return middle;
}

Console.WriteLine(MiddleOfNumber(1236983));