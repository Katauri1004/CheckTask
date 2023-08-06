# Руководство пользователя
Данная программа преобразовывает готовый массив в другой, где количество символов в элементе меньше либо равно 3.

## Описание работы программы

1. Вводим с клавиатуры массив с указанием размера и элементов.
```
string [] array = new string [6] {"they", "are", "not",   "stupid", "idiots", "no"};
```

 
2. Выводим данный массив на экран при помощи метода PrintArray, который последовательно выводит каждый элемент массива в консоль

```
void PrintArray (string [] arr)
{
    Console.Write(" [ ");
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write ($"[{arr [i]}]  ");
    
    }
    Console.Write(" ] ");
}
```
3. При помощи метода CreateFillAndPrintNewArray(array), формируем новый массив с соблюдением заданных требований : элементы нового массива должны состоять только из трех или менее символов.
```
void CreateFillAndPrintNewArray (string [] arr)
{   
    int size = 0;
    for (int j = 0; j< arr.Length; j++)
    {
        if (arr[j].Length<=3)
        {
            size++;
        }
    }
    int IndArr2 = 0;
    string [] arr2 = new string [size];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=3)
        {
            arr2[IndArr2] = arr[i];
            IndArr2++;
            
        }
    }
    
    PrintArray(arr2);
}
```
3.1 В первом цикле метода определяем размер нового массива, просчитывая элементы исходного массива, где количество символов меньше либо равно 3
```
int size = 0;
    for (int j = 0; j< arr.Length; j++)
    {
        if (arr[j].Length<=3)
        {
            size++;
        }
    }
```
3.2 Создаём новую переменную IndArr2 а также новый массив с соответствующим размером size
```
int IndArr2 = 0;
string [] arr2 = new string [size];
```
3.3 Во втором цикле метода мы заполняем новый массив элементами, двигаясь по старому, проверяя условие что в элементе 3 символа либо меньше. Для движения по элементам нового массива используем переменную IndArr2

```
for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=3)
        {
            arr2[IndArr2] = arr[i];
            IndArr2++;
            
        }
    }
``` 
3.4 В этом же методе используем метод PrintArray для вывода нового массива в консоль
```
PrintArray(arr2);
```
4. Используем команду Console.WriteLine для описания нового и исходного массива.
```
Console.WriteLine("Сформированный массив:");
Console.WriteLine("Исходный массив:");
```
5. Применяем метод CreateFillAndPrintNewArray(array) и при запуске программы получаем результат:
```
Исходный массив:

 [ [they]  [are]  [not]  [stupid]  [idiots]  [no]   ] 

Сформированный массив:

 [ [are]  [not]  [no]   ] 
```

# THE END!
