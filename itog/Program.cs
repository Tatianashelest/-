Console.Clear();
Console.Write ("Введите количество элементов массива: ");
int A = Convert.ToInt32(Console.ReadLine());
string [] Array;
int size = A;
Array = new string [size];

void FillArray (string [] collection)
{
    int number = collection.Length;
    int index = 0;
    while (index<number)
    {
    collection[index] = Convert.ToString (Console.ReadLine());
    index++;
    }

}
void PrintArray (string [] col)
{
    int length1=col.Length;
    int count = 0;
    while(count<length1)
    {
        count++;
    }
Console.WriteLine (String.Join(", ", col.Where(x=>x.Length<=3)));
}


FillArray (Array);
PrintArray (Array);