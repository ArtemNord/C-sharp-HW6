// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Lenght(int number)
{
    int i = 0;
    int result = number;
    int result1 = number;
    while (result1 != 0)
    {
        result = result1 / 2;
        result1 = result;
        i++;
    }
    // Console.WriteLine($" = {i}");
    return i;
}

double [] ConvertIntToBinaryArray(int number, int length)
{
    double [] array = new double [length];
    int result = number;
    int result1 = number;

    for (int i = 0; i < array.Length; i++)
    {
        if (result1 != 0) 
            {
                result = result1 / 2;
                array[i] = result1 - result * 2;
                result1 = result;
            }
        else array [i] = 0;
    }
    return array;
}

double [] CreatArrayRevers(double [] array)
{
    double [] number = new double [array.Length];
    int length = array.Length;
    
    for (int i = 0; i < array.Length; i++)
    {
        number[i] = array[length-1];
        length = length - 1;
    }
    return number;
}

void ShowArray(double [] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите число для ConvertToBinar: ");
int NumberForConvert = Convert.ToInt32(Console.ReadLine());
int length = Lenght (NumberForConvert);

double [] arr = ConvertIntToBinaryArray(NumberForConvert, length);
double [] number = CreatArrayRevers(arr);

// ShowArray(arr);
Console.Write($"Двоичный вид числа {NumberForConvert} = ");
ShowArray(number);