// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(100,1000);

// Выводим данные в консоль
Console.WriteLine(number);
 
 int fistNumber = number/100;
 int secondNumber = number%10;

 int result = fistNumber*10 + secondNumber;

 Console.WriteLine(result);
