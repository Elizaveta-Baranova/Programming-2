// Напишите программу, которая принимает на вход трёхзначное число
//на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите целое трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99 || number > 1000)
{
    Console.Write("Вы ввели не трёхзначное число!");
}
else
{
    number = number / 10 % 10;
    Console.Write("Вторая цифра введённого Вами числа является " + number);
} 

