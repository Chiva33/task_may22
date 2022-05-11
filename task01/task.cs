string[] arrayFirst = new string[10] {"Renault", "KIA", "Ford", "Skoda", "Lada", "Nissan", "JAC", "BMW", "UAZ", "Chevrolet"};
string[] arraySecond = new string[arrayFirst.Length];
void arraySecondOut(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
arraySecondOut(arrayFirst, arraySecond);
PrintArray(arraySecond);