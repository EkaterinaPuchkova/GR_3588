//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)

{
    //Парсим введеное число
    int num1 = int.Parse(inputLine);  
    
    if (num1 % 2 == 0)
    {
        Console.WriteLine("Число является четным");
    }
    else
    {
        Console.WriteLine("Число не является четным");
    }
}
