Console.Clear();
static void WriteArray(int[] array)
{
    Console.Write("[");
    int i = 0;
    int count = array.Length;

    while (i < count)
    {
        Console.Write(array[i]); i++;
        if (i < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
    
int[] array = new int[0];
while(true)
{
    Console.WriteLine("Введите значение массива или команду (end) - для завершения массива");
    string meaning = Console.ReadLine();
    if(meaning != "end")
    {
        int number = Convert.ToInt32(meaning);
        int[] newArray = array;
        array = new int[array.Length + 1];
        for(int i = 0; i < newArray.Length; i++)
        {
            array[i] = newArray[i];
        }
        array[array.Length-1] = number;
    }
    else
    {
        Console.WriteLine("Результат формирования массива:");
        break;
    }
}
WriteArray(array);