Console.WriteLine("Задача 25\n");

int[] nums = new int[] {new Random().Next(2, 10), new Random().Next(2, 10)};
Pow(nums);


Console.WriteLine("\nЗадача 27\n");

DigitSum(452);
DigitSum(82);
DigitSum(9012);

Console.WriteLine("\nЗадача 29\n");

ArrayCreator(8);

// ======================================================== \\

void Pow(int[] nums)
{
    int result = nums[0];
    int degree = nums[1];
    
    for (int i = 1; i < degree; i++)
    {
        result *= nums[0];
    }
    Console.WriteLine($"{nums[0]} в степени {nums[1]} = {result}");
}

void DigitSum(int n)
{
    int result = 0;
    int number = n;

    while(number > 0)
    {
        result += number % 10;
        number /= 10;
    }

    Console.WriteLine($"Cумма цифр в числе {n} = {result}");
}

void ArrayCreator(int n)
{
    int[] array = new int[8];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100);
        Console.Write($"{array[i]} ");
    }
}