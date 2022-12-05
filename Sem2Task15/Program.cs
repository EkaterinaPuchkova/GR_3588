//Считываем данное с консоли  проверяем, чтобы данные были не пустыми
int day = int.Parse(Console.ReadLine()?? "0");
// Проверяем условие
 if (day>0&&day<8)
    
    if (day<5)
    Console.WriteLine("День является рабочим");
    else
    Console.WriteLine("День является выходным");