void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
    {
    collection[index] = new Random().Next(1, 10);
    //index = index+1;
    index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position = -1;//искусственно создаем возможноть показать,что  такого эл нет
    while  (index< count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив в кот будет 10 эл

FillArray(array);//заполнил массив
array[4] = 4;
array[5] = 4;
PrintArray(array);//печать  массива
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);