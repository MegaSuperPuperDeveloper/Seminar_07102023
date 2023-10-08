// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] PullArray(int[] array) { // Функция заполняет массив рандомные числами от 1 до 10
    var rnd = new Random();
    int length = array.Length;
    for(int i = 0; i < length; i++) {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

int[] CopyPasteArray(int[] array) { // Копи Паст массива по элементам
    int length = array.Length;
    int[] array1 = new int[length];
    for(int i = 0; i < length; i++) {
        array1[i] = array[i];
    }
    return array1;
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

var rnd = new Random().Next(2, 10);
int[] arr = new int[rnd];
PullArray(arr);
PrintArray(CopyPasteArray(arr));