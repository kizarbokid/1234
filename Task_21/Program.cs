// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
string input()
{
    string result = Console.ReadLine();
    return result;
}

int[] A = new int[3];
int[] B = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите координату {i + 1}-й оси для числа A: ");
    A[i] = int.Parse(input());
}

for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите координату {i + 1}-й оси для числа B: ");
    B[i] = int.Parse(input());
}
int Xa = A[0]; int Xb = B[0];
int Ya = A[1]; int Yb = B[1];
int Za = A[2]; int Zb = B[2];


double dist = Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2)+Math.Pow(Zb-Za,2));

Console.WriteLine($"Расстояние между точками в пространстве равно {dist}");