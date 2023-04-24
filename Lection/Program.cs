int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}




// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 15;
// int b2 = 21;
// int c2 = 39;
// int a3 = 15;
// int b3 = 21;
// int c3 = 39;

// int max1 = Max(a1, b1, c1);
// Console.WriteLine(max1);

// int[] array = {1, 2, 3, 4, 5, 7, 19, 8};

// int n = array.Length;
// int find = 4;

// int index = 0

// while (index < n)
// {
//     if (array[index]==find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++
// }

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index ++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index ++;
//     }
//     return position;
// }


// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);
