
// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//   в которой находится эта точка.

void Zadacha17()
{
Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"A({x},{y})");
CoordCheck(x, y);
// if (x>0 && y>0)
// {
//     Console.WriteLine("Точка лежит в первой четверти");
// }
// else 
// if (x<0 && y>0)
// {
//     Console.WriteLine("Точка лежит во второй четверти");
// }
// else 
// if (x<0 && y<0)
// {
//     Console.WriteLine("Точка лежит в третьей четверти");
// }
// else 
// if (x>0 && y<0)
// {
//     Console.WriteLine("Точка лежит в четвертой четверти");
// }
// else 
// {
//     Console.WriteLine("Точка лежит на одной из осей");
// }
}
// Zadacha17();


void CoordCheck(int x, int y)
{
    if (x>0 && y>0)
{
    Console.WriteLine("Точка лежит в первой четверти");
}
else 
if (x<0 && y>0)
{
    Console.WriteLine("Точка лежит во второй четверти");
}
else 
if (x<0 && y<0)
{
    Console.WriteLine("Точка лежит в третьей четверти");
}
else 
if (x>0 && y<0)
{
    Console.WriteLine("Точка лежит в четвертой четверти");
}
else 
{
    Console.WriteLine("Точка лежит на одной из осей");
}
}

// Задача 18: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).



// void Line()
// {
// Console.WriteLine("Введите цифру четверти...");
// int number = Convert.ToInt32(Console.ReadLine());
// Zadacha2(number);
// }

// void Zadacha2(int number)
// {


// if(number == 1)
// {
// int x = new Random().Next(0,10);
// int y = new Random().Next(0,10);
// Console.WriteLine("Число из первой четверти = " + (x, y));
// }
// else if(number == 2)
// {
// int x = new Random().Next(0,10);
// int y = new Random().Next(-10,0);
// Console.WriteLine("Число из первой четверти = " + (x, y));
// }
// else if(number == 3)
// {
// int x = new Random().Next(-10,0);
// int y = new Random().Next(-10,0);
// Console.WriteLine("Число из первой четверти = " + (x, y));
// }
// else if(number == 4)
// {
// int x = new Random().Next(-10,0);
// int y = new Random().Next(0,10);
// Console.WriteLine("Число из первой четверти = " + (x, y));
// }
// }
// Line();

// Console.WriteLine("Введите номер четверти 1-4 ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num==1)
// {
// Console.WriteLine("некая четверть x>0 и y>0");
// }
// if (num==2)
// {
// Console.WriteLine("некая четверть x>0 и y>0");
// }
// if (num==3)
// {
// Console.WriteLine("некая четверть x<0 и y>0");
// }
// if (num==4)
// {
// Console.WriteLine("некая четверть x<0 и y<0");
// }

// Random RundNum = new Random();
// int q = RundNum.Next(1, 5);
// Console.WriteLine($"Задана ч етветь {q}");

// if (q == 1) Console.WriteLine($"Точки будут иметь координаты: (0 > X < ∞) и (0 > Y < ∞).");
// else if (q == 2) Console.WriteLine($"Точки будут иметь координаты: (-∞ < X < 0) и (0 > Y < ∞).");
// else if (q == 3) Console.WriteLine($"Точки будут иметь координаты: (-∞ < X < 0) и (-∞ < Y < 0).");
// else if (q == 4) Console.WriteLine($"Точки будут иметь координаты: (0 > X < ∞) и (-∞ < Y < 0).");
// else Console.WriteLine($"Указана несуществующая четверть.");

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

void task_21(){
Console.WriteLine("Введите координаты точки А: ");
Console.WriteLine("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int by = Convert.ToInt32(Console.ReadLine());

int k = bx - ax;
int m = by - ay;

double length = Math.Sqrt(k * k + m * m);
length = Math.Round(length, 2);
Console.WriteLine($"Длина {length}");
}
// task_21();

Random RundNum = new Random();
int Ax = RundNum.Next(-10, 11);
int Ay = RundNum.Next(-10, 11);
int Bx = RundNum.Next(-10, 11);
int By = RundNum.Next(-10, 11);

Console.WriteLine($"Точки: A({Ax}, {Ay}), B({Bx}, {By})");
Console.WriteLine($"Расстояние между точками А и В: {Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2))}");

void zadacha21()
{
Console.WriteLine("Задача 21");

Random random = new Random();

int x1 = random.Next(0, 100);
int y1 = random.Next(0, 100);
int x2 = random.Next(0, 100);
int y2 = random.Next(0, 100);

Console.WriteLine($"A {x1}, {y1}");
Console.WriteLine($"B {x2}, {y2}");
Dist(x1, y1, x2, y2);
}


void Dist(int x1, int y1, int x2, int y2)
{

Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");


}


// zadacha21();

// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

void task_23()
{
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число\tКвадрат");
for (int i = 1; i <= number; i++)
{
Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i,2));
}

}
// task_23();

void Zadacha22()
{
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
double Sqw;
while (i <= N)
{
Sqw = Math.Pow(i,2);
Console.WriteLine($"|{i}|{Sqw}|");
i++;
}
}
// Zadacha22();


void zadacha22()

{
Console.WriteLine("Задача 22");
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
result(num);
}

void result(int num)
{
int i = 1;
if (num > 1)
{
while (i <= num)
{
Console.WriteLine($"Квадрат числа {i} = {Math.Pow((i), 2)}");
i++;
}
}
else
{
while (num <= 1)
{
Console.WriteLine($"Квадрат числа {num} = {Math.Pow((num), 2)}");
num++;
}
}

}

zadacha22();