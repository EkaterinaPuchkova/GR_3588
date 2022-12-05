//Считываем данное с консоли  проверяем, чтобы данные были не пустыми
int number = int.Parse(Console.ReadLine()?? "0");

//Проверяем условие
if (number>99)
{
    char[] digits = number.ToString().ToCharArray();
    Console.WriteLine(digits[2]);
}
else
{
    Console.WriteLine("Третьего числа нет");
}


 