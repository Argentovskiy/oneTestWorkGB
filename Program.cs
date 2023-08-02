// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
//===========================================================================

using System.Globalization;

void printArray(string[] strArr)
{
  System.Console.Write("[");
  for (int i = 0; i < strArr.Length; i++)
  {
    if(i<strArr.Length-1) Console.Write($"“{strArr[i]}”,");
    else Console.Write($"“{strArr[i]}”");
  }
  System.Console.Write("]");
}

string[] lengthLessthet(string[] StrArr)
{
  
  int k=0;
  for (int i = 0; i < StrArr.Length; i++) if(StrArr[i].Length<=3)k++;
  string[] result =new string[k];
  
  int j=0;
  for (int i = 0; i < StrArr.Length; i++)
  {
    if(StrArr[i].Length<=3)
    {
      result[j]=StrArr[i];
      j++;
    }
 }
 return result;
}

string[] StringArray = {"Hello", "211", "world", ":-)","12"};
printArray(StringArray);

System.Console.Write(" → ");
printArray(lengthLessthet(StringArray));
