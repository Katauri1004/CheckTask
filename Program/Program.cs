void PrintArray (string [] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write ($"[{arr [i]}]  ");
    
    }
}
string [] array = new string [6] {"if", "slame", "tap", "global", "supreme", "OK"};
PrintArray (array);
