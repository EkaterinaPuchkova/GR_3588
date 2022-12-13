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
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

//Метод возведения в степень
int Pow(int a, int b)
{
    int result = 1;
    for(int i=1;i<=b;i++)
    {
        result = a * result;
    }
    return result;
    // Console.WriteLine(result);
}

int numberA = ReadData(" Введите число А: ");
int numberB = ReadData(" Введите число B: ");
int result = Pow( numberA ,  numberB);
PrintData(" A в степени B равно: " + result);

