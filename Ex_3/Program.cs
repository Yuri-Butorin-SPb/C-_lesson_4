// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] arr = CreateArray();

PrintArray(arr);


int[] CreateArray()
{
    Console.WriteLine ("Задайте длинну массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int [size];
    int meaning = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine ($"Введите {meaning} элемент массива: ");
        int num = int.Parse(Console.ReadLine());
        array [i] = num;
        meaning++;
    }
    return array;
}

void PrintArray(int [] arr)
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write (arr [i] + " ");
    }
    Console.Write ("]");
}




