// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10
void PrintArray(int[] array) { // Функция выводит массив
    int length = array.Length;
    for(int i = 0; i < length; i++) {
        Console.Write(array[i]);
    }
}

int Count(int num) { // Функция считает сколько раз надо сделать деление
    int count = 1;
    while(num / 2 != 0) {
        num /= 2;
        count++;
    }
    return count;
}

int[] DoubleSystem(int num) { // Функция переводит число в двоичную систему
    int count = Count(num);
    int[] array = new int[count];
    for(int i = 0; i < count; i++) {
        if(num % 2 == 0) {
            array[i] = 0;
        } else {
            array[i] = 1;
        }
        num /= 2;
    }
    Array.Reverse(array);
    return array;
}

Console.Write("Введите число которое надо перевезти в двоичную систему: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");
PrintArray(DoubleSystem(num));