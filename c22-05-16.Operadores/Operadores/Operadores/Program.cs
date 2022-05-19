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
using Exercise6;
using Exercise7;
using Exercise8;
using Exercise9;
using Exercise10;

Console.WriteLine("Exercise 1: {0}", AverageAge.Run(20, 50));

Console.WriteLine("Exercise 2: {0}", await ExchangeRate.Run(2));

Console.WriteLine("Exercise 3: {0}", Commission.Run(500_000));

Console.WriteLine("Exercise 4: {0}", CelsiusToFahrenheit.Run(25));

Console.WriteLine("Exercise 5: {0}", FahrenheitToCelsius.Run(100));

Console.WriteLine("Exercise 6: {0}", IBWMale.Run(1.8));

Console.WriteLine("Exercise 7: {0} {1}", FinalGrade.Run(new double[] { 10, 6, 8 }, out string status), status);

Console.WriteLine("Exercise 8: {0} {1}", Sub.Run(10, 20, out string state), state);

Console.WriteLine("Exercise 9: {0}", Div.Run(1, 0));

Console.WriteLine("Exercise 10: Running..."); UserInteraction.Run();
