// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(1,100);

// // Выводим данные в консоль
// Console.WriteLine(number);

//Получаем первое и второе число поотдельности
int fistNumber = number/10;
int secondNumber = number%10;

//Сравниваем числа
if (fistNumber>secondNumber)
{
    // //Выводим данные в консоль
    // Console.WriteLine(fistNumber);
}
else
{
    // Console.WriteLine(secondNumber);
}

// Вариант2

char[] digits = numberSintezator.Next(1,100).ToString().ToCharArray();
Console.WriteLine(digits);
fistNumber = ((int)digits[0])-48;
secondNumber =((int)digits[1])-48;

int resultNumber = fistNumber>secondNumber?resultNumber=fistNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);