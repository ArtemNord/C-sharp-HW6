// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

int [] ReadLineNumber (int length)
{
    int [] arrayNumber = new int [length];
    int count = 0;
    while (count != length)
    {
        Console.Write($"Введите число {count + 1}: " );
        arrayNumber[count] = Convert.ToInt32(Console.ReadLine());
        count ++;
    }
    return arrayNumber;
}

int HowManyNumbersAreGreaterThanZero (int [] array)
{
    int result = 0; 

    for (int i=0; i<array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

void ShowArray(int [] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


Console.Write($"Укажите сколько чисел Вы собираетесь ввести: " );
int number = Convert.ToInt32(Console.ReadLine());

int [] array = ReadLineNumber (number);
// ShowArray(array);

int result = HowManyNumbersAreGreaterThanZero (array);

Console.WriteLine();
Console.WriteLine($"{result} чисел - больше чем 0");