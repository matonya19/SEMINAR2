// Задание 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа


Console.WriteLine("Введите трехзначное число: ");
string N = Console.ReadLine();
Console.WriteLine(N[1]);


//Задание 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string N = Convert.ToString(num);
if (N.Length > 2)
{
    Console.WriteLine(N[2]);
}
else {
    Console.Write("третьей цифры нет");
}


// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, я
// является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7) 
{
    Console.WriteLine("Этот день выходной!");
}
else {
    Console.WriteLine("Этот день не выходной!");
}