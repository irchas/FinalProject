// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите длину массива:");
int size = int.Parse(Console.ReadLine());

string [] array = new string[size];
Console.WriteLine("Введите массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write("array[{0}] = ", i);
    array[i] = Console.ReadLine();
}
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("Новый массив:");

string[] newarray  = new string[size];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarray[i] = array[i];
            Console.Write($"{newarray[i]}, ");
        }
        else newarray[i] = "";
    }