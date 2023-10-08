// // Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] PullArray(int[] array) { // Функция заполняет массив рандомные числами от 1 до 10
    var rnd = new Random();
    int length = array.Length;
    for(int i = 0; i < length; i++) {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

void Reverse(int[] array) { // Функция делает реверс массива
    int length = array.Length;
    for(int i = 0; i < length / 2; i++) {
        (array[length - 1 - i], array[i]) = (array[i], array[length - 1 - i]);
    }
}

void PrintArray(int[] array) { // Функция выводит массив
    Console.Write("[");
    int length = array.Length;
    for(int i = 0; i < length; i++) {
        Console.Write(array[i]);
        if(i != length - 1) {
            Console.Write(" ");
        }
    }
    Console.Write("]");
}

int[] array = new int[6];
PullArray(array);
PrintArray(array);
Console.WriteLine();
Reverse(array);
PrintArray(array);
Console.WriteLine();
Array.Reverse(array);
PrintArray(array);