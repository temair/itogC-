//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Печать массива
void PrintArr(string[] arr, string message = "Массив: ")
{
    Console.WriteLine($"{message}[{string.Join(", ", arr)}]");
}

// Фильтр массива, длина строки меньше 4.
string[] LessThree(string[] words)
{
    int index = 0;
    string[] result = new string[words.Length];
    foreach (string word in words)
    {
        if (word.Length < 4)
        {
            result[index] = word;
            index++;
        }
    }
    Array.Resize(ref result, index);
    return result;
}

string[] arr = { "tuegy", "ji", "rew", "jgdrygxat", "ywtc" };
PrintArr(arr, message: "Исходный массив: ");
PrintArr(LessThree(arr), message: "Отфильтрованный массив: ");
