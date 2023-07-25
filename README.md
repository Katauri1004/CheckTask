# Руководство пользователя
Данная программа преобразовывает готовый массив в другой, где количество символов в элементе меньше либо равно 3.

## Описание работы программы

>string [] array = new string [6] {"they", "are", "not",   "stupid", "idiots", "no"};

 
   Вводим с клавиатуры массив с указанием размера и элементов.
`void PrintArray (string [] arr)
{
    Console.Write(" [ ");
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write ($"[{arr [i]}]  ");
    
    }
    Console.Write(" ] ");
}
`