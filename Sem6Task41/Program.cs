// int Number = ReadData("Введите элементы(через пробел): ");
// PrintData("Кол-во элементов больше 0: " + CountPosNum(Number));

// //Метод, считывающий данные, введенные пользователем
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод, выводящий на печать данные пользователю
// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }
// // Метод, вычесление чисел > 0
// int CountPosNum( int num)
// {
//    int res = 0;
//     while (num > 0)
//     {
//         if(ReadData("Введите элементы(через пробел): ")>0) res++;
//         num=num-1;
//     }
//     return res;

// }


Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");