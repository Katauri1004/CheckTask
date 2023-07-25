using System.Drawing;

void PrintArray (string [] arr)
{
    Console.Write(" [ ");
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write ($"[{arr [i]}]  ");
    
    }
    Console.Write(" ] ");
}
string [] array = new string [6] {"they", "are", "not", "stupid", "idiots", "no"};
Console.WriteLine("Исходный массив:");
Console.WriteLine ("");
PrintArray (array);
Console.WriteLine ("");

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
Console.WriteLine("");
Console.WriteLine("Сформированный массив:");
Console.WriteLine("");
CreateFillAndPrintNewArray(array);
