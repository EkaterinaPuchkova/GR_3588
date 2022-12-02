//Считываем данные с консоли
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null && Num2Line != null)
{
    //Парсим введенные числа
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);
    
    //Проверяем условие задачи
    if (num1>num2)

{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Первое число меньше второго");
}

}

