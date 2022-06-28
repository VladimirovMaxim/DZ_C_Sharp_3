// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeLine(int N)
{
    int count = 1;
    while( count <= N)
    {
        int cube = count * count * count;
        Console.Write(cube + " ");
        count ++;
    }
  
}
Console.WriteLine("Введите натуральное число ");
int N = Convert.ToInt32(Console.ReadLine());
CubeLine(N);