// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите целое число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.Write("Понедельник - будний день");
}
if (number == 2)
{
    Console.Write("Вторник - будний день");
}
if (number == 3)
{
    Console.Write("Среда - будний день");
}
if (number == 4)
{
    Console.Write("Четверг - будний день");
}
if (number == 5)
{
    Console.Write("Пятница - будний день");
}
if (number == 6)
{
    Console.Write("Суббота - выходной день");
}
if (number == 7)
{
    Console.Write("Воскресенье - выходной день");
}
if (number != 1 && number != 2 && number != 3 && number != 4 && number != 5 && number != 6 && number != 7)
{
    Console.Write("Неверное число ввода!");
}