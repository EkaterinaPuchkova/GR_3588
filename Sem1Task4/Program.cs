//Считываем данные с консоли
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();
string? Num3Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (Num1Line != null && Num2Line != null && Num3Line != null)

{
    //Парсим введенное число
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);
    int num3 = int.Parse(Num3Line);
    

    if (num2>=num1 && num2>=num3)
    {
       Console.WriteLine("Второе число является максимальным");
    }
    if (num3>=num1 && num3>=num2)
    {
       Console.WriteLine("Третье число является максимальным");
    }
     if (num1>=num2 && num1>=num3)
     {
        Console.WriteLine("Первое число является максимальным");
     }
      
}
