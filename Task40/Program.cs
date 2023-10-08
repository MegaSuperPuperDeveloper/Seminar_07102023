// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool CheckTriangle(int a, int b, int c) {
    return a + b > c && b + c > a && a + c > b;
}

Console.Write("Введите значение первой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение второй стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение третьей стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
bool check = CheckTriangle(a, b, c);
if(check == true) {
    Console.WriteLine("Треугольник со значениями данных сторон возможен");
} else {
    Console.WriteLine("Треугольник со значениями данных сторон невозможен");
}