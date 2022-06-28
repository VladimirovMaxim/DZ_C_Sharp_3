
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Palindrome(int num)
{
    if (num<10000 || num >= 100000)
    {
        Console.WriteLine("Число не является пятизначным!");
    } 
    else
    {
        int digit1= num /10000;
        int digit2 = (num / 1000) % 10;
        int digit4 = (num /10) % 10;
        int digit5 = num % 10;
        if( digit1== digit5 && digit2==digit4)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    
}
Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);