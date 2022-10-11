// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string input()
{
    Console.Write("Введите число/слово: ");
    string result = Console.ReadLine();
    return result;
}
string text = (input());

char[] strreverse = text.ToCharArray(); // делаем из строки массив, чтобы затем перевернуть его
Array.Reverse(strreverse); // переворачиваем массив (со строками такого метода нет)
string textreverse=String.Concat<char>(strreverse); // обратно делаем из массива строку

if (textreverse.ToLower() == text.ToLower()) //добавим нечуствительность к регистру
   {Console.WriteLine("Да, это палиндром");}
else
    {Console.WriteLine("Нет, это не палиндром");}

