// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.


Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99)
{
    Console.Write("В введеном числе нет третьей цифры!");
}
if (number > 99 && number < 1000)
{
    number = number % 10;
    Console.Write("Третья цифра введённого Вами числа является " + number);
}
if (number > 999 && number < 10000)
{
    number = number / 10 % 10;
    Console.Write("Третья цифра введённого Вами числа является " + number);
}
if (number > 9999 && number < 100000)
{
    number = number / 100 % 10;
    Console.Write("Третья цифра введённого Вами числа является " + number);
}
if (number > 99999 && number < 1000000)
{
    number = number / 1000 % 10;
    Console.Write("Третья цифра введённого Вами числа является " + number);
}
if (number > 1000000)
{
    Console.Write("Слишком большое число для решения этой задачи.");
}