//Запрос данных у пользователя
int ReadData(string Line)
{
    //Выводим сообщение
    Console.Write(Line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number; //Возращаем значение
}
// Метод вывода результата
void PrintData(string res)
{
    Console.WriteLine(res);
}

long CalcFactor(int num)
{
    long count = 1;
    for(int i=1;i<=num;i++)
    {
        count *= i;
    }
    return count;
}

int number = ReadData(" Введите число А:");
long lenght = CalcFactor(number);
PrintData(" Факториал равно^ " + lenght);