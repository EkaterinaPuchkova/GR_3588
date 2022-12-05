//Считываем данное с консоли  проверяем, чтобы данные были не пустыми
int number = int.Parse(Console.ReadLine()?? "0");

//Выходное значение
int result = ((number/10) %10);

// Проверяем условие
if (number<1000&& number>99)

    Console.WriteLine(result);

else

    Console.WriteLine("Число не является трехзначным");

