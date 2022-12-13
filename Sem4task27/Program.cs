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
// Метод вывода суммы цифр в числе
int SumNumbers(int num)
{
    int sum = 0;
    while(num>0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return(sum);
}

int number = ReadData("Введите число: ");
int sum = SumNumbers(number);
PrintData(" Сумма всех цифр в числе равна: " + sum );