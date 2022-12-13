// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }



int lenArray = ReadData("Введите длинну массива: ");




//Запрос данных у пользователя
int ReadData(string msg)
{
   
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод вывода результата
void PrintData(string res, int[] arr )
{
    Console.WriteLine(res);
}



int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


