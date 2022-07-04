//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;

int cube( int num)
{
    int c = num*num*num;
    return c;
}
 while(index <= num)
{
    Console.WriteLine(cube(index));
    index++;
}
