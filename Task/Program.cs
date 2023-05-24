// // Напишите программу, которая из имеющегося массива строк формирует новый массив из строк, длина 
// которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] initialArray = new string[] { "Hello", "World", "My", "Name", "is", "Jack", "ee" };
DisplayArray(initialArray);


int resultArrayCount = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        resultArrayCount++;
    }
}

string[] resultArray = new string[resultArrayCount];

int resultArrayIndex = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        resultArray[resultArrayIndex++] = initialArray[i];
    }
}


DisplayArray(resultArray);


void DisplayArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"\"{array[i]}\"");
        }
        else
        {
            Console.Write($"\"{array[i]}\", ");
        }
    }
    Console.WriteLine(" ]");
}
