// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//string[] Text = { "Hello", "2", "world", ";-)" };

void FillArray(string[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.WriteLine("Введите элемент массива ");
    arr[i] = Console.ReadLine();
  }
}

void PrintArray(string[] ar)
{
  for (int i = 0; i < ar.Length; i++)
  {
    Console.Write(ar[i] + ", ");
  }
  Console.WriteLine();
}

string[] text = new string[4];

FillArray(text);
Console.WriteLine();
Console.WriteLine("Начальный массив");
PrintArray(text);
Console.WriteLine();

Console.WriteLine("Искомый массив");
string[] text2 = new string[] { };
for (int i = 0; i < text.Count(); i++)
{
  if (text[i].Length <= 3)
  {
    text2 = text;
    Console.Write(text2[i] + ", ");
  }
}

