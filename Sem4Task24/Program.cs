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

int VariantSumSimple(int numA)
{
    int sumOfnumbers = 0;
    for(int i= 1; i<=numA; i++ )
    {
        sumOfnumbers+=i;
    }
    return sumOfnumbers;
}

int VariantSumGause(int numA)
{
    int sumOfnumbers = 0;
    sumOfnumbers = ((1 + numA)*numA) / 2;
    return sumOfnumbers;
}

int numberA = ReadData( " Введите число A: " );
int res1 = VariantSumSimple(numberA);
int res2 = VariantSumGause(numberA);
PrintResult(" Сумма чисел от 1 до А равна(простой метод): " + res1);
PrintResult(" Сумма чисел от 1 до А равна(простой Гауса): " + res1);