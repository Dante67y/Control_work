// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Напишите несколько любых слов или целых чисел через 'пробел' и нажмите 'Enter': ");
string[] array = Console.ReadLine().Split(' ');
Console.WriteLine("Ваш массив: [" + string.Join(", ", array) + "]");
string[] FinalArray = new string[array.Length];
void CheckArray(string[] array, string[] FinalArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            FinalArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] FinalArray)
{
    Console.WriteLine("Конечный массив с введёнными Вами значеними до 3х символов: ");
    for (int i = 0; i < FinalArray.Length; i++)
    {
        Console.Write($"{FinalArray[i]} ");
    }
    Console.WriteLine();
}
CheckArray(array, FinalArray);
PrintArray(FinalArray);
