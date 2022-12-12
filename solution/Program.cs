//Программа которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string fillArray(string[]finalArray, int size, int j, int len, string[]array)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= len)
        {
            
            finalArray[j] = array[i];
            j++;   
            
        }
    }
    return finalArray[j];
}

int size = 4;
string[] array = {"Hello", "2", "world", ":-)"};
string[] finalArray = new string [size];
int len = 3;
int j = 0;
fillArray(finalArray, size, j, len,array);
Console.WriteLine(string.Join(" ",finalArray));

