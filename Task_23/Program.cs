// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
string input()
{
    Console.Write("Введите число: ");
    string result = Console.ReadLine();
    return result;
}
int len = int.Parse(input());
int[] arr = new int[len]; // определили массив длинной len-1


for (int i = 1; i < (len+1); i++)
{
    arr[i-1] = Convert.ToInt32(Math.Pow(i , 3));
    Console.Write($"{arr[i-1]}; ");
}

