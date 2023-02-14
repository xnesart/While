//Задание1) Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
Console.WriteLine("Задание 1");
Console.WriteLine("Введите число");
int value = int.Parse(Console.ReadLine());
int temp = 1;
int result = 0;
while (value > temp)
{
    if (value % temp == 0)
    {
        result = temp;
    }
    temp++;
}
Console.WriteLine(result);

// Задание 2) Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
Console.WriteLine("Задание 2");
Console.WriteLine("Введите число А");
//делимое
int value1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
//делитель
int value2 = int.Parse(Console.ReadLine());
//остаток
int value3 = value1 % value2;
if (value3 == 0)
{
    Console.WriteLine(value2);
}
else
{
    while (value3 != 0)
    {
        int tmp = value3;
        value3 = value1 % value2;
        value1 = value2;
        value2 = value3;
        if (value3 == 0)
        {
            Console.WriteLine(tmp);

        }
    }

}
//Задание 3) Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
Console.WriteLine("Задание 3");
Console.WriteLine("Введите число");
int element = int.Parse(Console.ReadLine());
int remain = 0;
int odd = 0;
int summary = 0;
while (element > 0)
{
    remain = element % 10;
    element = element / 10;
    if (remain % 2 != 0)
    {
        odd = remain;
        summary++;
    }
}
Console.WriteLine(summary);
Console.ReadLine();

//Задание 4) реверс числа
Console.WriteLine("Задание 4");
Console.WriteLine("Введите число");
int userNumber = int.Parse(Console.ReadLine());
int storage = 0;
string newValueString = "";
if (userNumber % 10 == 0)
{
    throw new ArgumentException("число заканчивается нулём, ошибка");
}
while (userNumber != 0)
{
    storage = userNumber % 10;
    newValueString += storage;
    userNumber = userNumber / 10;
}
int newValue = int.Parse(newValueString);
Console.WriteLine(newValue);
//Задание 5 *) Пользователь вводит целое положительное число, которое является кубом числа N.
//Найдите число N методом половинного деления.
//Console.WriteLine("Задание 5");
