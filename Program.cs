// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.Write("Для нахождения расстояния между двумя точками ");
Console.WriteLine("введите кординаты Х первой точки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты Y первой точки: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты Z первой точки: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты X второй точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты Y второй точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты Z второй точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
double ab = Math.Sqrt (Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2) + Math.Pow((z - z1), 2));
Console.Write(ab);
Console.Write (" <- Расстояние между двумя точками в 3D пространстве");