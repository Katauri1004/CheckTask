void PrintArray (string [] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write ($"[{arr [i]}]  ");
    
    }
}
string [] array = new string [6] {"if", "slame", "tap", "global", "supreme", "OK"};
PrintArray (array);

void CreateFillAndPrintNewArray (string [] arr)
{   int IndArr2 = 0;
    string [] arr2 = new string [6];

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
CreateFillAndPrintNewArray(array);
