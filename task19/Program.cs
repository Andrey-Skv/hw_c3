//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.


Console.WriteLine("введите 5-тизначное число");
int num =Convert.ToInt32(Console.ReadLine());
while(num < 9999 | num > 99999)
{
    Console.WriteLine("введите 5-тизначное число");
    num =Convert.ToInt32(Console.ReadLine());
}

void pal (int num1)
{
  if (num.ToString()[0] == num.ToString()[4] && num.ToString()[1] == num.ToString()[3])
{
    Console.WriteLine("Число палиндром");
}
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}
pal(num);