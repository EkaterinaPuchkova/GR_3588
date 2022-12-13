//Запрос данных у пользователя
int ReadData(string Line)
{
    //Выводим сообщение
    Console.Write(Line);
    //Считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //Возращаем значение
}
// Метод вывода результата
void PrintResult(string Line)
{
    Console.WriteLine(Line);
}

int VariantLog(int num);
{
    int result = (int)Math.Log10(num)+1;
    return result;
}

int number = ReadData(" Введите число А:");
int lenght = VariantLog(number);
PrintData(" Колличество цифр в чесле равно^ " + lenght);