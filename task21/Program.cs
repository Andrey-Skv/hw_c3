//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты X1");
double quartX1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y1");
double quartY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z1");
double quartZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат X2");
double quartX2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат Y2");
double quartY2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z2");
double quartZ2 = Convert.ToInt32(Console.ReadLine());

double first = Math.Pow((quartX2-quartX1),2) + Math.Pow((quartY2-quartY1),2) + Math.Pow((quartZ2-quartZ1),2);

Console.WriteLine(Math.Sqrt(first));