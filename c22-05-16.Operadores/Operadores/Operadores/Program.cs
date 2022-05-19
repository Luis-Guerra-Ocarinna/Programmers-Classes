//// Class
//int num = 10;
//string txt = "Foo";
//txt = "Bar";

//var v1 = 101; /* var delcara em tempo de excução, não provem dinamicidade */
//v1 = "baz" # Cannot implicit convert string to int
using Exercise1;
using Exercise2;
using Exercise3;
using Exercise4;
using Exercise5;

Console.WriteLine("Exercise 1: {0}", AverageAge.Run(20, 50));

Console.WriteLine("Exercise 2: {0}", await ExchangeRate.Run(2, 5.6M));

Console.WriteLine("Exercise 3: {0}", Commission.Run(500_000));

Console.WriteLine("Exercise 4: {0}", CelsiusToFahrenheit.Run(25));

Console.WriteLine("Exercise 5: {0}", FahrenheitToCelsius.Run(100));