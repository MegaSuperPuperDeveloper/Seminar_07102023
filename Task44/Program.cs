// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void CheckIt(int N) { // Функция проверяет, введенное число меньше 2 или нет. Если да то выводит некорректный ввод
    int[] array1 = Fibonaci(N);
    if(array1[0] < 2) {
        Console.WriteLine("Некорректный ввод!");
    } else {
        Console.Write($"Если N = {N} -> ");
        PrintArray(Fibonaci(N));
    }
}

int[] Fibonaci(int N) { // Выводит числа перед введненным числом, исползуя только Фибоначи
    int[] num1 = {1};
    if(N < 2) return num1;
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < N; i++) {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array) { // Функция выводит массив
    int length = array.Length;
    for(int i = 0; i < length; i++) {
        Console.Write(array[i]);
        if(i != length - 1) {
            Console.Write(" ");
        }
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
CheckIt(N);