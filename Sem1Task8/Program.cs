//Считываем данное с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
    //Парсим введеное число
    int inputNumber = int.Parse(inputLine);

    //Выходное значение
    int startNumber = 0;
    string outLine = string.Empty;

    while (startNumber<inputNumber) 
         
    {   startNumber = startNumber + 2;
        outLine = outLine + startNumber + ",";
    }
    
    Console.WriteLine(outLine);
}

