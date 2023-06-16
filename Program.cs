/* Задача 2


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number1 > number2)
    {
    Console.WriteLine($"Первое число {number1} больше, чем второе число {number2}");
    }
else
    {
    Console.WriteLine($"Второе число {number2} больше, чем первое число {number1}");
    }
*/


/* Задача 4


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());


int max = number1;


if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;


Console.Write($"Максимальное число из введенных чисел {number1}, {number2}, {number3}. Это - {max}");
*/


/*Задача 6


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
    {
    Console.Write($"Введенное число {number} является четным");
    }
else
    {
    Console.Write($"Введенное число {number} является нечетным");
    }
*/


//Задача 8


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;


if (number>=0)
{
        while (count <= number)
        {
        if (count % 2 == 0)
            {
            Console.Write(count + ", ");
            count ++;
            }
        else
            {
            count ++;
            }    
        }
}
else
{
    Console.WriteLine("Ошибка, введите число больше 0");
}

