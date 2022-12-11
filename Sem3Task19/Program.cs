// int num = ReadData(" Введите число: ");
// bool result = PalinTest(num);
// PrintData("Число является палиндромом" , result);

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData( int num, string msg)
//  {
//     Console.WriteLine(num + msg);
//  }

// bool PalinTest(int num)
//  {   
//     bool result = false;
//     if (num>9999&&num<100000)
//     {
//         if ((num/10000 == num%10)&&((num/1000)%10 == (num/10)%10));
//     } 
//     else Console.WriteLine("Вы ввели не пятизначное число"); 
//     return result;
//  }


//Вариант2

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}

